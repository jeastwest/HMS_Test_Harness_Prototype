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
    public partial class PrecipitationComparison : Form
    {
        public PrecipitationComparison()
        {
            InitializeComponent();
        }

        private void PrecipitationComparison_Load(object sender, EventArgs e)
        {
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
            string URL = Globals.baseURL + Globals.precipCompareURL;
            RequestBodyPrecipCompare rbPrecipCompare = new RequestBodyPrecipCompare();
            rbPrecipCompare.dataset = "Precipitation";

            /*Developer note: Still working on creating a proper string format
             The user can only select one "Data Source" at a time */
            //building sourceList request

            string sourcesChecked = "";
            if (cBoxNLDAS.Checked)
            {
                sourcesChecked = sourcesChecked + cBoxNLDAS.Text.ToLower();
            }
            if (cBoxGLDAS.Checked)
            {
                sourcesChecked = sourcesChecked + cBoxGLDAS.Text.ToLower();
            }
            if (cBoxTRMM.Checked)
            {
                sourcesChecked = sourcesChecked + cBoxTRMM.Text.ToLower();
            }

            rbPrecipCompare.sourceList = new string[] { sourcesChecked };

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

            return responseString;
        }
    }
}
