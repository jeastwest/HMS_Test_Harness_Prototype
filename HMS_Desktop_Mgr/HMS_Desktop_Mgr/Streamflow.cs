using Newtonsoft.Json;
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
        public Streamflow()
        {
            InitializeComponent();
        }

        private void Streamflow_Load(object sender, EventArgs e)
        {
            ddlAOI.DataSource = Enum.GetValues(typeof(Globals.streamflowAOI));
            ddlAlgorithm.DataSource = Enum.GetValues(typeof(Globals.runoffAndFlowAlgorithms));
            pnlPrecipSource.Visible = false;
            ddlPrecipSource.DataSource = Enum.GetValues(typeof(Globals.streamflowPrecipSources));
            ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResultionDaily));
            ddlStreamHydrologyAlgorithm.DataSource = Enum.GetValues(typeof(Globals.StreamHydrologyAlgorithms));
            lblWarning.Visible = false;
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
            lblWarning.Visible = true;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = true;
        }
    }
}
