
/*This program is designed as a "test harness" for HMS web products. 
  Users will be prompted to select a module or workflow to get data.
 
 */


using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;
using System.Collections;

namespace HMS_Desktop_Mgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        /*Initializing a blank startup screen.
        You must select a module from the drop down list to continue.
        */
        {
            ddlModules.DataSource = Enum.GetValues(typeof(Globals.moduleList));
            ddlAOI.Visible = false;
            ddlSource.Visible = false;
            ddlOutputDataFormat.Visible = false;
            ddlTimeZone.Visible = false;
            ddlTemporalResolution.Visible = false;
            pnlAlgorithm.Visible = false;
            pnlLatLng.Visible = false;
            pnlCOMID.Visible = false;
            pnlStationID.Visible = false;
            pnlTimeSpan.Visible = false;
            pnlAlbedo.Visible = false;
            lblAOI.Visible = false;
            lblSource.Visible = false;
            lblTimeZone.Visible = false;
            lblOutputDataFormat.Visible = false;
            lblTemporalResolution.Visible = false;
            btnSubmitPrecip.Visible = false;
        }


        //The code below calls a function that reorganizes the display in respect to the desired module.
        private void moduleSelection(object sender, EventArgs e) 
        {
            setDisplays();
        }


        private void setDisplays() //This method is tricky but eliminates the need for an entirely separate page for each module.
        {
            switch (ddlModules.SelectedValue.ToString())
            {
                case "Precipitation":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Air_Temperature":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.temperatureSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Relative_Humidity":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Dew_Point":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Solar_Radiation":
                    clearDataViews();
                    ddlAOI.Visible = true;
                    ddlSource.Visible = true;
                    ddlOutputDataFormat.Visible = true;
                    ddlTimeZone.Visible = true;
                    ddlTemporalResolution.Visible = true;
                    pnlAlgorithm.Visible = false;
                    pnlLatLng.Visible = true;
                    pnlCOMID.Visible = true;
                    pnlStationID.Visible = false;
                    pnlTimeSpan.Visible = true;
                    pnlSource.Visible = true;
                    pnlLayerDepth.Visible = false;
                    lblAOI.Visible = true;
                    lblSource.Visible = true;
                    lblTimeZone.Visible = true;
                    lblOutputDataFormat.Visible = true;
                    lblTemporalResolution.Visible = true;
                    btnSubmitPrecip.Visible = true;
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.solarRadiationSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Wind":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.windSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Surface_Runoff":
                    clearDataViews();
                    ddlAOI.Visible = true;
                    ddlSource.Visible = true;
                    ddlOutputDataFormat.Visible = true;
                    ddlTimeZone.Visible = true;
                    ddlTemporalResolution.Visible = true;
                    pnlAlgorithm.Visible = true;
                    pnlLatLng.Visible = true;
                    pnlCOMID.Visible = true;
                    pnlStationID.Visible = false;
                    pnlTimeSpan.Visible = true;
                    pnlSource.Visible = false;
                    pnlLayerDepth.Visible = false;
                    pnlAlbedo.Visible = false;
                    lblAOI.Visible = true;
                    lblSource.Visible = true;
                    lblTimeZone.Visible = true;
                    lblOutputDataFormat.Visible = true;
                    lblTemporalResolution.Visible = true;
                    btnSubmitPrecip.Visible = true;
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlAlgorithm.DataSource = Enum.GetValues(typeof(Globals.runoffAndFlowAlgorithms));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Subsurface_Flow":
                    clearDataViews();
                    ddlAOI.Visible = true;
                    ddlSource.Visible = true;
                    ddlOutputDataFormat.Visible = true;
                    ddlTimeZone.Visible = true;
                    ddlTemporalResolution.Visible = true;
                    pnlAlgorithm.Visible = true;
                    pnlLatLng.Visible = true;
                    pnlCOMID.Visible = true;
                    pnlStationID.Visible = false;
                    pnlTimeSpan.Visible = true;
                    pnlSource.Visible = false;
                    pnlLayerDepth.Visible = false;
                    pnlAlbedo.Visible = false;
                    lblAOI.Visible = true;
                    lblSource.Visible = true;
                    lblTimeZone.Visible = true;
                    lblOutputDataFormat.Visible = true;
                    lblTemporalResolution.Visible = true;
                    btnSubmitPrecip.Visible = true;
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlAlgorithm.DataSource = Enum.GetValues(typeof(Globals.runoffAndFlowAlgorithms));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Soil_Moisture":
                    clearDataViews();
                    ddlAOI.Visible = true;
                    ddlSource.Visible = true;
                    ddlOutputDataFormat.Visible = true;
                    ddlTimeZone.Visible = true;
                    ddlTemporalResolution.Visible = true;
                    pnlAlgorithm.Visible = false;
                    pnlLatLng.Visible = true;
                    pnlCOMID.Visible = true;
                    pnlStationID.Visible = false;
                    pnlTimeSpan.Visible = true;
                    pnlSource.Visible = true;
                    pnlLayerDepth.Visible = true;
                    pnlAlbedo.Visible = false;
                    lblAOI.Visible = true;
                    lblSource.Visible = true;
                    lblTimeZone.Visible = true;
                    lblOutputDataFormat.Visible = true;
                    lblTemporalResolution.Visible = true;
                    btnSubmitPrecip.Visible = true;
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.soilMoistureSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    ddlLayerDepth.DataSource = Enum.GetValues(typeof(Globals.LayerDepth));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                case "Evapotranspiration":
                    clearDataViews();
                    ddlAOI.Visible = true;
                    ddlSource.Visible = true;
                    ddlOutputDataFormat.Visible = true;
                    ddlTimeZone.Visible = true;
                    ddlTemporalResolution.Visible = true;
                    pnlAlgorithm.Visible = true;
                    pnlLatLng.Visible = true;
                    pnlCOMID.Visible = true;
                    pnlStationID.Visible = false;
                    pnlTimeSpan.Visible = true;
                    pnlSource.Visible = true;
                    pnlLayerDepth.Visible = false;
                    pnlAlbedo.Visible = false;
                    lblAOI.Visible = true;
                    lblSource.Visible = true;
                    lblTimeZone.Visible = true;
                    lblOutputDataFormat.Visible = true;
                    lblTemporalResolution.Visible = true;
                    btnSubmitPrecip.Visible = true;
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlAlgorithm.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationAlgorithms));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationSources));
                    ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
                    ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
                    ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
                    pnlLatLng.Enabled = true;
                    pnlCOMID.Enabled = false;
                    pnlStationID.Enabled = false;
                    break;
                default:
                    lblError.Text = "Error: Unknown module selected";
                    break;
            }
        }

        //Clears data, outputs, and errors. This is called whenever a user selects a different module.
        private void clearDataViews() 
        {
            lblError.Text = "";
            txtOutputs.Text = "";
            dgvOutputs.DataSource = null;
        }

        //Sets the template to modules Precip, Temp, Relative Humitity, Dew Point, and Wind
        private void setControlsVisibility()
        {
            ddlAOI.Visible = true;
            ddlSource.Visible = true;
            ddlOutputDataFormat.Visible = true;
            ddlTimeZone.Visible = true;
            ddlTemporalResolution.Visible = true;
            pnlAlgorithm.Visible = false;
            pnlLatLng.Visible = true;
            pnlCOMID.Visible = true;
            pnlStationID.Visible = true;
            pnlTimeSpan.Visible = true;
            pnlSource.Visible = true;
            pnlLayerDepth.Visible = false;
            pnlAlbedo.Visible = false;
            lblAOI.Visible = true;
            lblSource.Visible = true;
            lblTimeZone.Visible = true;
            lblOutputDataFormat.Visible = true;
            lblTemporalResolution.Visible = true;
            btnSubmitPrecip.Visible = true;
        }
  
        /* Certain modules have an "Algorithm" parameter.
         * The application format will change sometimes based on what algorithm is set.
         * For example, when algorithm "curvenumber" is selected. A drop down list for "Precipiation Sources" will appear.
         */
        private void ddlAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlModules.SelectedValue.ToString()) {
                case "Subsurface_Flow":
                    switch (ddlAlgorithm.SelectedValue.ToString().ToLower())
                    {
                        case "nldas":
                            pnlSource.Visible = false;
                            break;
                        case "gldas":
                            pnlSource.Visible = false;
                            break;
                        case "curvenumber":
                            pnlSource.Visible = true;
                            break;
                    }
                    break;
                case "Surface_Runoff":
                    switch (ddlAlgorithm.SelectedValue.ToString().ToLower())
                    {
                        case "nldas":
                            pnlSource.Visible = false;
                            break;
                        case "gldas":
                            pnlSource.Visible = false;
                            break;
                        case "curvenumber":
                            pnlSource.Visible = true;
                            break;
                    }
                    break;
                case "Evapotranspiration":
                    switch (ddlAlgorithm.SelectedValue.ToString().ToLower())
                    {
                        case "nldas":
                            ddlSource.DataSource = null;
                            ddlSource.Items.Add("nldas");
                            pnlAlbedo.Visible = false;
                            break;
                        case "gldas":
                            ddlSource.DataSource = null;
                            ddlSource.Enabled = false;
                            pnlAlbedo.Visible = false;
                            break;
                        case "hamon":
                            ddlSource.Enabled = true;
                            pnlAlbedo.Visible = false;
                            break;
                        case "penmandaily":
                            ddlSource.Enabled = true;
                            pnlAlbedo.Visible = true;
                            break;
                        case "hargreaves":
                            ddlSource.Enabled = true;
                            pnlAlbedo.Visible = false;
                            break;
                    }
                    break;
            }
        }

        //Geographic options 
        private void ddlAOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAOI.SelectedValue.ToString() == "LatitudeLongitude")
            {
                setDisplays();
                pnlLatLng.Enabled = true;
                pnlCOMID.Enabled = false;
                pnlStationID.Enabled = false;
            }
            else if (ddlAOI.SelectedValue.ToString() == "COMID")
            {
                setDisplays();
                pnlLatLng.Enabled = false;
                pnlCOMID.Enabled = true;
                pnlStationID.Enabled = false;
            }
            if (ddlAOI.SelectedValue.ToString() == "NCEI_Station")
            {
                ddlSource.DataSource = null;
                ddlSource.Items.Add("ncei");
                ddlSource.SelectedIndex = 0;
                pnlLatLng.Enabled = false;
                pnlCOMID.Enabled = false;
                pnlStationID.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clearDataViews();
            lblError.Text = "";
            string strResponse = "";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                strResponse = getData();
            }
            catch (System.Exception ex)
            {
                txtOutputs.Text = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private string getData()
        {
            DataTable dt = null;
            string URL = Globals.baseURL + Globals.precipitaionURL;

            RequestBody requestBody = new RequestBody();


            switch (ddlModules.SelectedValue.ToString())
            {
                case "Precipitation":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.precipitaionURL;
                    break;
                
                case "Air_Temperature":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.temperatureURL;
                    break;

                case "Relative_Humidity":
                    lblError.Text = "";
                    requestBody.relative = true;
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.relHumidityURL;
                    break;

                case "Dew_Point":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.dewPointURL;
                    break;
                case "Solar_Radiation":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.solarRadiationURL;
                    break;
                case "Wind":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.windURL;
                    break;
                case "Surface_Runoff":
                    lblError.Text = "";
                    if (ddlAlgorithm.SelectedValue.ToString() != "curvenumber")
                    {
                        requestBody.source = ddlSource.SelectedItem.ToString();
                    }
                    else
                    {
                        requestBody.source = ddlAlgorithm.SelectedItem.ToString();
                        requestBody.precipSource = ddlSource.SelectedItem.ToString();
                    }
                    URL = Globals.baseURL + Globals.surfaceRunoffURL;
                    break;
                case "Subsurface_Flow":
                    lblError.Text = "";
                    if (ddlAlgorithm.SelectedValue.ToString() != "curvenumber")
                    {
                        requestBody.source = ddlSource.SelectedItem.ToString();
                    }
                    else
                    {
                        requestBody.source = ddlAlgorithm.SelectedItem.ToString();
                        requestBody.precipSource = ddlSource.SelectedItem.ToString();
                    }
                    URL = Globals.baseURL + Globals.subsurfaceFlowURL;
                    break;
                case "Soil_Moisture":
                    lblError.Text = "";
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    requestBody.layers = new string[] { ddlLayerDepth.SelectedItem.ToString().Replace("From", "").Replace("To", "-"), "10-40" }; 
                    URL = Globals.baseURL + Globals.soilMoistureURL;
                    break;
                case "Evapotranspiration":
                    lblError.Text = "";
                    if (ddlAlgorithm.SelectedItem.ToString() == "penmandaily")
                    {
                        requestBody.source = ddlSource.SelectedItem.ToString();
                        requestBody.albedo = Convert.ToDouble(txtAlbedo.Text);
                    }
                    else
                    {
                        requestBody.source = ddlSource.SelectedItem.ToString();
                    }
                    requestBody.algorithm = ddlAlgorithm.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.evapotranspirationURL;
                    break;
                default:
                    lblError.Text = "Error: Unknown module requested";
                    break;
            }



            //requestBody.dateTimeSpan.dateTimeFormat = null;
            requestBody.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";
            requestBody.dateTimeSpan.endDate = txtEndDate.Text + "T00:00:00";
            requestBody.dateTimeSpan.startDate = txtStartDate.Text + "T00:00:00"; //  "2015 -01-01T00:00:00";

            requestBody.geometry.geometryMetadata = null;
            requestBody.geometry.timezone = null;
            if (ddlAOI.SelectedItem.ToString() == "COMID")
            {
                requestBody.geometry.description = "COMID";
                requestBody.geometry.comID = Convert.ToInt32(txtCOMID.Text);
                requestBody.geometry.point = null;
                requestBody.geometry.stationID = null;
                requestBody.geometry.hucID = null;
            }
            else if (ddlAOI.SelectedItem.ToString() == "LatitudeLongitude")
            {
                requestBody.geometry.description = null;
                requestBody.geometry.comID = 0;
                requestBody.geometry.point.latitude = Convert.ToDouble(txtLatitude.Text);
                requestBody.geometry.point.longitude = Convert.ToDouble(txtLongitude.Text);
                requestBody.geometry.stationID = null;
                requestBody.geometry.hucID = null;
            }
            else if (ddlAOI.SelectedItem.ToString() == "NCEI_Station")
            {
                requestBody.source = "ncei";
                requestBody.geometry.description = "StationID";
                requestBody.geometry.comID = 0;
                requestBody.geometry.point.latitude = 0;
                requestBody.geometry.point.longitude = 0;
                requestBody.geometry.stationID = txtStationID.Text;
                requestBody.geometry.hucID = null;
            }


            
            requestBody.dataValueFormat = ddlOutputDataFormat.SelectedItem.ToString();
            requestBody.temporalResolution = ddlTemporalResolution.SelectedItem.ToString();
            if (ddlTimeZone.SelectedValue.ToString() == "Local")
            {
                requestBody.timeLocalized = true;
            }
            else
            {
                requestBody.timeLocalized = false;
            }
            
            requestBody.units = "metric";
            requestBody.outputFormat = "json";
            requestBody.baseURL = null;
            requestBody.inputTimeSeries = null;


            string myJson = JsonConvert.SerializeObject(requestBody);

            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Clear();
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"*/*";
            txtInputRequest.Text = myJson.ToString();

            var data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(requestBody));
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            txtOutputs.Text = responseString;

           
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
            foreach (KeyValuePair<string,string>  col in colSorted)
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
                    dr[i+1] = valSet[i];
                }
                dt.Rows.Add(dr);
            }

            dgvOutputs.DataSource = dt.DefaultView;

            return responseString;
        }

    

        private void btnSaveMetaData_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInputData_Click(object sender, EventArgs e)
        {

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
                //if ((myStream = saveFileDialog1.OpenFile()) != null)
                //{
                // Code to write the stream goes here.
                if (dgvOutputs.Rows.Count > 1)
                    {
                        int counter = 1;
                        int numColumns = dgvOutputs.Columns.Count;
                        foreach (DataGridViewRow row in dgvOutputs.Rows)
                        {
                            //int counter = 1;

                            string line = "";
                            // if (counter > 1)
                            //{
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
                            //}
                            counter++;
                        }
                    }
                    myStream.Close();
                //}
            }
        }

        private void lnkWorkFlows_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WorkflowNavigator frm = new WorkflowNavigator();
            frm.ShowDialog();
        }
    }
}
