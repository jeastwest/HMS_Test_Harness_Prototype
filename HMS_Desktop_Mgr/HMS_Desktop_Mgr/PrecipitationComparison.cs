using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Desktop_Mgr
{
    public partial class PrecipitationComparison : Form
    {
        List<string> metaDataForExport = new List<string>();
        public PrecipitationComparison()
        {
            InitializeComponent();
        }

        private void PrecipitationComparison_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 575);
            pnlStationID.Visible = false;
            btnDaily.Checked = true;
        }

        //If checked, the function below will make the NCEI Station ID panel visible
        private void chkNCEIStationID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNCEIStationID.Checked == true)
            {
                pnlStationID.Visible = true;
            }
            else
            {
                pnlStationID.Visible = false;
            }
        }

        private void btnSubmitPrecipExtract_Click(object sender, EventArgs e)
        {
            string strResponse = "";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                strResponse = getData();
            }
            catch (System.Exception ex)
            {
                rTxtUnformattedOutput.Text = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private string getData()
        {
            DataTable dt = null;
            string URL = Globals.baseURL + Globals.precipCompareURL;
            RequestBodyPrecipCompare rbPrecipCompare = new RequestBodyPrecipCompare();
            rbPrecipCompare.dataset = "Precipitation";

            //building sourceList request
            List<string> sourcesChecked = new List<string>();
            foreach (Control c in pnlDataSources.Controls)
            {
                if ((c.GetType().Name == "CheckBox") && ((CheckBox)c).Checked)
                {
                    sourcesChecked.Add(c.Text.ToLower());
                }
            }
            rbPrecipCompare.sourceList = sourcesChecked.ToArray();

            //Seeing if the spatial average box is checked
            if (chkSpatialAverage.Checked)
            {
                rbPrecipCompare.weighted = true;
            }
            else
            {
                rbPrecipCompare.weighted = false;
            }

            rbPrecipCompare.extremeDaily = Convert.ToDouble(txtDailyPrecipThreshold.Text);
            rbPrecipCompare.extremeTotal = Convert.ToDouble(txtTotalPrecip.Text);
            rbPrecipCompare.source = "compare";
            rbPrecipCompare.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";

            //Yearly values are taken: January 1st to January 1st.
            rbPrecipCompare.dateTimeSpan.startDate = txtStartYear.Text + "-01-01T00:00:00";
            rbPrecipCompare.dateTimeSpan.endDate = txtEndYear.Text + "-01-01T00:00:00"; //  "2015 -01-01T00:00:00";

            rbPrecipCompare.geometry.description = null;
            rbPrecipCompare.geometry.timezone = null;

            //Creating request body based on selected parameters
            if (btnNHDplusCOMID.Checked)
            {
                rbPrecipCompare.geometry.comID = Convert.ToInt32(txtNHDplusCOMID.Text);

                if (chkNCEIStationID.Checked)
                {
                    rbPrecipCompare.geometry.stationID = txtNCEIStation.Text;
                }
                else
                {
                    rbPrecipCompare.geometry.stationID = null;
                }
            }
            else
            {
                rbPrecipCompare.geometry.comID = 0;
                rbPrecipCompare.geometry.stationID = txtNCEIStation.Text;
            }

            rbPrecipCompare.dataValueFormat = "E3";
            rbPrecipCompare.timeLocalized = true;

            //This allows the user to select the temporal resolution
            if (btnDaily.Checked)
            {
                rbPrecipCompare.temporalResolution = "daily";
            }
            else if (btnMonthly.Checked)
            {
                rbPrecipCompare.temporalResolution = "monthly";
            }
            else if (btnAnnual.Checked)
            {
                rbPrecipCompare.temporalResolution = "annual";
            }
            else if (btnExtremePrecip.Checked)
            {
                rbPrecipCompare.temporalResolution = "extreme";
            }

            rbPrecipCompare.outputFormat = "json";
            rbPrecipCompare.baseURL = null;
            rbPrecipCompare.inputTimeSeries = null;

            string myJson = JsonConvert.SerializeObject(rbPrecipCompare);

            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Clear();
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"*/*";
            rTxtRequestBody.Text = myJson.ToString();

            var data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(rbPrecipCompare));
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            rTxtUnformattedOutput.Text = responseString;


            var result = JObject.Parse(responseString);
            var items = result["data"].Children().ToList();   //Get the data section and save as a list
            var metaItems = result["metadata"].Children().ToList();
            DataTable dtMetaData = new DataTable();
            dtMetaData.Columns.Add("Item");
            dtMetaData.Columns.Add("Value");

            dt = new DataTable();
            SortedList<string, string> colSorted = new SortedList<string, string>();
            foreach (JToken mLabel in metaItems)
            {
                DataRow dr = dtMetaData.NewRow();
                metaDataForExport.Add(mLabel.ToString());
                mLabel.ToObject<JProperty>();
                string item = mLabel.ToObject<JProperty>().Name;
                System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("column_[1-9]");

                if ((rgx.IsMatch(item)) && (item.Length == 8))
                {
                    dr["Item"] = item.Trim();
                    string val = mLabel.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    dr["Value"] = val;
                    dtMetaData.Rows.Add(dr);
                    //dt.Columns.Add(val);
                    colSorted.Add(item.Trim(), val);
                }
            }
            foreach (KeyValuePair<string, string> col in colSorted)
            {
                dt.Columns.Add(col.Value);
            }



            //Generating output data table 
            foreach (JToken item in items)
            {
                DataRow dr = dt.NewRow();
                item.ToObject<JProperty>();
                string date = item.ToObject<JProperty>().Name;
                dr[0] = date.Trim();
                string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                string[] valSet = val.Split(',');
                var valCount = valSet.Count();

                for (int i = 0; i < valCount; i++)
                {
                    dr[i + 1] = valSet[i];
                }
                dt.Rows.Add(dr);
            }

            dgvOutputs.DataSource = dt.DefaultView;


            return responseString;

        }



        private void btnSaveInputData_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
                    myStream.WriteLine(rTxtRequestBody.Text);
                    myStream.Close();
                }


            }
        }

            private void btnSaveMetaData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < metaDataForExport.Count; i++)
                {
                    string str = metaDataForExport[i].ToString().Replace('"', '\0');
                    int idx = str.IndexOf(":");
                    str = str.Remove(idx, 1).Insert(idx, ",");
                    // Code to write the stream goes here.
                    myStream.WriteLine(str);
                }
                myStream.Close();
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);

                // Code to write the stream goes here.
                if (dgvOutputs.Rows.Count > 1)
                {
                    int counter = 1;
                    int numColumns = dgvOutputs.Columns.Count;
                    foreach (DataGridViewRow row in dgvOutputs.Rows)
                    {
                        string line = "";
                        for (int i = 0; i < numColumns; i++)
                        {
                            string val = row.Cells[i].Value?.ToString() + ",";
                            line = line + val.Trim();
                        }
                        if (!String.IsNullOrEmpty(line))
                        {
                            while (line.EndsWith(","))
                            {
                                line = line.Remove(line.Length - 1);
                            }
                            if (!String.IsNullOrEmpty(line))
                            {
                                myStream.WriteLine(line);
                            }
                        }
                        counter++;
                    }
                }
                myStream.Close();
            }
        }
    }
}
