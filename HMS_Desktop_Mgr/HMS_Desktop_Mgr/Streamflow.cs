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
    public partial class Streamflow : Form
    {
        List<string> metaDataForExport = new List<string>();
        public Streamflow()
        {
            InitializeComponent();
        }

        private void Streamflow_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1195, 425);
            ddlAOI.DataSource = Enum.GetValues(typeof(Globals.streamflowAOI));
            ddlAlgorithm.DataSource = Enum.GetValues(typeof(Globals.runoffAndFlowAlgorithms));
            pnlPrecipSource.Visible = false;
            ddlPrecipSource.DataSource = Enum.GetValues(typeof(Globals.streamflowPrecipSources));
            ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResultionDaily));
            ddlStreamHydrologyAlgorithm.DataSource = Enum.GetValues(typeof(Globals.StreamHydrologyAlgorithms));
            
            //Generating the tooltips
            ToolTip StreamflowTooltips = new ToolTip();
            StreamflowTooltips.SetToolTip(ddlAOI, "Select the Area of Interest");
            StreamflowTooltips.SetToolTip(txtCOMIDandHucID, "Enter the catchment ID or HucID");
            StreamflowTooltips.SetToolTip(ddlAlgorithm, "Select an algorithm from the list");
            StreamflowTooltips.SetToolTip(ddlPrecipSource, "Select a precipitation source from the list");
            StreamflowTooltips.SetToolTip(ddlTemporalResolution, "Select a time interval for the dataset");
            StreamflowTooltips.SetToolTip(txtStartDate, "Enter start time for the dataset");
            StreamflowTooltips.SetToolTip(txtEndDate, "Enter an end time for the dataset");
            StreamflowTooltips.SetToolTip(ddlStreamHydrologyAlgorithm, "Select a streamflow algorithm for the dataset");
            StreamflowTooltips.SetToolTip(btnSubmitStreamflow, "Click here to send the request");
            StreamflowTooltips.SetToolTip(btnSaveInputData, "Click to export the request body as a .txt file");
            StreamflowTooltips.SetToolTip(btnSaveMetaData, "Click to export the meta data as a .csv file");
            StreamflowTooltips.SetToolTip(btnSaveData, "Click to export the data as a .csv file");
        }

        private void ddlAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlAlgorithm.SelectedValue.ToString())
            {
                case "nldas":
                    pnlPrecipSource.Visible = false;
                    break;
                case "gldas":
                    pnlPrecipSource.Visible = false;
                    break;
                case "curvenumber":
                    pnlPrecipSource.Visible = true;
                    break;
            }
        }

        private void btnSubmitStreamflow_Click(object sender, EventArgs e)
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

        private void ddlAOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlAOI.SelectedValue.ToString())
            {
                case "COMID":
                    lblCOMIDandHucID.Text = "COMID: ";
                    txtCOMIDandHucID.Text = "13891106";
                    break;
                case "HucID":
                    lblCOMIDandHucID.Text = "HucID: ";
                    txtCOMIDandHucID.Text = "030502040102";
                    break;
            }
        }

        private string getData()
        {
            DataTable dt = null;
            string URL = Globals.baseURL + Globals.streamflowURL;
            RequestBodyStreamflow rbStreamflow = new RequestBodyStreamflow();
            rbStreamflow.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";
            rbStreamflow.dateTimeSpan.endDate = txtEndDate.Text + "T00:00:00";
            rbStreamflow.dateTimeSpan.startDate = txtStartDate.Text + "T00:00:00"; //  "2015 -01-01T00:00:00";

            rbStreamflow.geometry.description = null;
            rbStreamflow.geometry.timezone = null;

            rbStreamflow.aggregation = false;
            if (ddlAOI.SelectedItem.ToString() == "COMID")
            {
                rbStreamflow.geometry.hucID = null;
                rbStreamflow.geometry.comID = Convert.ToInt32(txtCOMIDandHucID.Text);
            }
            else if (ddlAOI.SelectedItem.ToString() == "HucID")
            {
                rbStreamflow.geometry.comID = 0;
                rbStreamflow.geometry.hucID = Convert.ToString(txtCOMIDandHucID.Text);
            }

            rbStreamflow.runoffSource = ddlAlgorithm.SelectedItem.ToString();

            if (ddlAlgorithm.SelectedValue.ToString() != "curvenumber")
            {
                rbStreamflow.source = null;
                rbStreamflow.geometry.geometryMetadata.precipSource = null;
            }
            else
            {
                rbStreamflow.geometry.geometryMetadata.precipSource = ddlPrecipSource.SelectedItem.ToString();
            }

            rbStreamflow.streamHydrology = ddlStreamHydrologyAlgorithm.SelectedItem.ToString();

            rbStreamflow.dataValueFormat = "E3";
            rbStreamflow.temporalResolution = "default";
            rbStreamflow.timeLocalized = true;
            rbStreamflow.units = "default";
            rbStreamflow.outputFormat = "json";
            rbStreamflow.baseURL = null;
            rbStreamflow.inputTimeSeries = null;


            string myJson = JsonConvert.SerializeObject(rbStreamflow);

            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Clear();
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"*/*";
            rTxtRequestBody.Text = myJson.ToString();

            var data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(rbStreamflow));
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            rTxtUnformattedOutput.Text = responseString;

            var result = JObject.Parse(responseString);

            //Getting the list of catchments from the metadata
            string[] catchments = result["metadata"]["catchments"].ToString().Split(',');
            var catchmentCount = catchments.Count();

            //Organizing the metadata
            var items = result["data"].Children().ToList();   //Get the data section and save as a list
            var metaItems = result["metadata"].Children().ToList();
            DataTable dtMetaData = new DataTable();
            dtMetaData.Columns.Add("Item");
            dtMetaData.Columns.Add("Value");

            dt = new DataTable();
            SortedList<string, string> colSorted = new SortedList<string, string>();

            //Adding metadata to a data table
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
                    colSorted.Add(item.Trim(), val);
                }
            }
     
            dt.Columns.Add("COMID");
            dt.Columns.Add("Date (GMT)");
            dt.Columns.Add("Precipitation (mm)");
            dt.Columns.Add("Surface Runoff (mm)");
            dt.Columns.Add("Subsurface Runoff (mm)");
            dt.Columns.Add(@"Streamflow (m^3/s)");

            /*Adding data from catchments. The "Streamflow" workflow contains quite a bit of data.
              This is sorting the data by catchment and organizing each column by dataset. */

            for (int i = 0; i < catchments.Length; i++)
            {
                items = result["data"][catchments[i]]["Precipitation"]["data"].Children().ToList();
                foreach (JToken item in items)
                {
                    DataRow dr = dt.NewRow();
                    item.ToObject<JProperty>();
                    dr["COMID"] = catchments[i];
                    string date = item.ToObject<JProperty>().Name;
                    dr["Date (GMT)"] = date.Trim();

                    string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    string[] valSet = val.Split(',');
                    var valCount = valSet.Count();

                    for (int j = 0; j < valCount; j++)
                    {
                        dr["Precipitation (mm)"] = valSet[j];
                    }
                    dt.Rows.Add(dr);
                }
            }

            for (int i = 0; i < catchments.Length; i++)
            {
                items = result["data"][catchments[i]]["SurfaceRunoff"]["data"].Children().ToList();
                foreach (JToken item in items)
                {
                    item.ToObject<JProperty>();
                    string date = item.ToObject<JProperty>().Name;

                    string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    string[] valSet = val.Split(',');
                    var valCount = valSet.Count();

                    for (int j = 0; j < valCount; j++)
                    {
                        DataRow[] drs = dt.Select("COMID ='" + catchments[i].ToString() + "' and [Date (GMT)] = '" + item.ToObject<JProperty>().Name + "'");
                        drs[0]["Surface Runoff (mm)"] = valSet[j];
                    }
                }
            }

            for (int i = 0; i < catchments.Length; i++)
            {
                items = result["data"][catchments[i]]["SubsurfaceRunoff"]["data"].Children().ToList();
                foreach (JToken item in items)
                {
                    item.ToObject<JProperty>();
                    string date = item.ToObject<JProperty>().Name;

                    string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    string[] valSet = val.Split(',');
                    var valCount = valSet.Count();

                    for (int j = 0; j < valCount; j++)
                    {
                        DataRow[] drs = dt.Select("COMID ='" + catchments[i].ToString() + "' and [Date (GMT)] = '" + item.ToObject<JProperty>().Name + "'");
                        drs[0]["Subsurface Runoff (mm)"] = valSet[j];
                    }
                }
            }

            for (int i = 0; i < catchments.Length; i++)
            {
                items = result["data"][catchments[i]]["StreamHydrology"]["data"].Children().ToList();
                foreach (JToken item in items)
                {
                    item.ToObject<JProperty>();
                    string date = item.ToObject<JProperty>().Name;

                    string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    string[] valSet = val.Split(',');
                    var valCount = valSet.Count();

                    for (int j = 0; j < valCount; j++)
                    {
                        DataRow[] drs = dt.Select("COMID ='" + catchments[i].ToString() + "' and [Date (GMT)] = '" + item.ToObject<JProperty>().Name + "'");
                        drs[0]["Streamflow (m^3/s)"] = valSet[j];
                    }
                }
            }

            dgvOutputs.DataSource = dt.DefaultView; 
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

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
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
