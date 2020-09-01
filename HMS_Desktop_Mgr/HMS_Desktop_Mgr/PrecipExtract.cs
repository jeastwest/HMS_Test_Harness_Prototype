using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
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
    public partial class PrecipExtract : Form
    {
        List<string> metaDataForExport = new List<string>();
        public PrecipExtract()
        {
            InitializeComponent();
        }

        private void PrecipExtract_Load_1(object sender, EventArgs e)
        {
            ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolutionMoDaily));
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

            string URL = Globals.baseURL + Globals.precipExtractURL;
            RequestBodyPrecipExtract rbPrecipExtract = new RequestBodyPrecipExtract();
            rbPrecipExtract.sourceList = new string[] { "ncei" };
            rbPrecipExtract.source = "extraction";
            rbPrecipExtract.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";
            rbPrecipExtract.dateTimeSpan.startDate = txtStartDate.Text + "T00: 00:00";
            rbPrecipExtract.dateTimeSpan.endDate = txtEndDate.Text + "T00: 00:00";

            rbPrecipExtract.geometry.geometryMetadata = null;
            rbPrecipExtract.geometry.timezone = null;


            //Geometry class parameters added to request body
            rbPrecipExtract.geometry.description = "StationID";
            rbPrecipExtract.geometry.comID = 0;
            rbPrecipExtract.geometry.point.latitude = 0;
            rbPrecipExtract.geometry.point.longitude = 0;
            rbPrecipExtract.geometry.stationID = txtStationID.Text;
            rbPrecipExtract.geometry.hucID = null;


            rbPrecipExtract.dataValueFormat = "E3";
            rbPrecipExtract.temporalResolution = ddlTemporalResolution.SelectedItem.ToString();
            rbPrecipExtract.timeLocalized = false;
            rbPrecipExtract.units = "metric";
            rbPrecipExtract.outputFormat = "json";
            rbPrecipExtract.baseURL = null;
            rbPrecipExtract.inputTimeSeries = null;

            string myJson = JsonConvert.SerializeObject(rbPrecipExtract);

            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Clear();
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"*/*";
            rTxtRequestBody.Text = myJson.ToString();


            var data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(rbPrecipExtract));
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
                //if (item.Contains("column_") && ((item.EndsWith("1")) || (item.EndsWith("2")) || (item.EndsWith("3")) || (item.EndsWith("4"))))

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

            dgvPrecipExtractOutputs.DataSource = dt.DefaultView;

            return responseString;
        }

        private void btnSaveInputData_Click(object sender, EventArgs e)
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
                if (dgvPrecipExtractOutputs.Rows.Count > 1)
                {
                    int counter = 1;
                    int numColumns = dgvPrecipExtractOutputs.Columns.Count;
                    foreach (DataGridViewRow row in dgvPrecipExtractOutputs.Rows)
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


