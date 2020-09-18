
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
using System.Drawing;

namespace HMS_Desktop_Mgr
{
    public partial class Form1 : Form
    {
        List<string> metaDataForExport = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        /* Initializing a blank startup screen.
        You must select a module from the drop down list to continue.
        */
        {
            this.Size = new Size(915, 555);
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
            btnImportInput.Visible = false;
            btnSumbitCustomInput.Visible = false;

            //Generating tool tips
            ToolTip MainFormTooltips = new ToolTip();
            MainFormTooltips.SetToolTip(lnkWorkFlows, "Click to view all available workflows");
            MainFormTooltips.SetToolTip(hlpModules, "Click for help");
            MainFormTooltips.SetToolTip(ddlModules, "Select a module from the list to begin");
            MainFormTooltips.SetToolTip(ddlAOI, "Select the area of interest from the list");
            MainFormTooltips.SetToolTip(ddlAlgorithm, "Enter an algorithm to use");
            MainFormTooltips.SetToolTip(txtLatitude, "Enter Latitude (Y Value)");
            MainFormTooltips.SetToolTip(txtLongitude, "Enter Longitude (X Value)");
            MainFormTooltips.SetToolTip(txtCOMID, "Enter a Catchment ID number");
            MainFormTooltips.SetToolTip(txtStationID, "Enter a NCEI Station ID");
            MainFormTooltips.SetToolTip(ddlSource, "Select a data source");
            MainFormTooltips.SetToolTip(ddlTimeZone, "Pick either Local or GMT times");
            MainFormTooltips.SetToolTip(txtStartDate, "Select a data start time");
            MainFormTooltips.SetToolTip(txtEndDate, "Select a data end time");
            MainFormTooltips.SetToolTip(ddlOutputDataFormat, "Select an output format for the dataset");
            MainFormTooltips.SetToolTip(ddlTemporalResolution, "Select the time interval for the data return");
            MainFormTooltips.SetToolTip(ddlLayerDepth, "Select a layer depth");
            MainFormTooltips.SetToolTip(txtAlbedo, "Enter an albedo value");
            MainFormTooltips.SetToolTip(btnSubmitPrecip, "Click here to send the request");
            MainFormTooltips.SetToolTip(btnSaveInputData, "Click to export the request body as a .txt file");
            MainFormTooltips.SetToolTip(btnSaveMetaData, "Click to export the meta data as a .csv file");
            MainFormTooltips.SetToolTip(btnSaveData, "Click to export the data as a .csv file");
        }
        

        //The code below calls a function that reorganizes the display in respect to the desired module.
        private void moduleSelection(object sender, EventArgs e) 
        {
            if (chkCustomRequestInput.Checked == false)
            {
                setDisplays();
            }
        }

        //This method is tricky but eliminates the need for an entirely separate page for each module.
        private void setDisplays() 
        {
            switch (ddlModules.SelectedValue.ToString())
            {
                case "Precipitation":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
                    break;

                case "Air_Temperature":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.temperatureSources));
                    break;

                case "Relative_Humidity":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
                    break;

                case "Dew_Point":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
                    break;

                case "Solar_Radiation":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.pointAndCOMIDAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.solarRadiationSources));
                    break;

                case "Wind":
                    clearDataViews();
                    setControlsVisibility();
                    ddlAOI.DataSource = Enum.GetValues(typeof(Globals.everyAOI));
                    ddlSource.DataSource = Enum.GetValues(typeof(Globals.windSources));
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
                    ddlLayerDepth.DataSource = Enum.GetValues(typeof(Globals.LayerDepth));
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
                    break;
                default:
                    break;
            }
        }

        //Clears data, outputs, and errors. This is called whenever a user selects a different module.
        private void clearDataViews() 
        {
            txtInputRequest.Text = "";
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
            ddlOutputDataFormat.DataSource = Enum.GetValues(typeof(Globals.OutputFormat));
            ddlTimeZone.DataSource = Enum.GetValues(typeof(Globals.TimeZone));
            ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResolution));
            pnlLatLng.Enabled = true;
            pnlCOMID.Enabled = false;
            pnlStationID.Enabled = false;
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
                            ddlSource.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationSources));
                            ddlSource.Enabled = true;
                            pnlAlbedo.Visible = false;
                            break;
                        case "penmandaily":
                            ddlSource.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationSources));
                            ddlSource.Enabled = true;
                            pnlAlbedo.Visible = true;
                            break;
                        case "hargreaves":
                            ddlSource.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationSources));
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
                ddlSource.DataSource = null;
                pnlLatLng.Enabled = true;
                pnlCOMID.Enabled = false;
                pnlStationID.Enabled = false;
            }
            if (ddlAOI.SelectedValue.ToString() == "COMID")
            {
                ddlSource.DataSource = null;
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

            if (ddlAOI.SelectedValue.ToString() == "NCEI_Station")
            {
                return;
            }
            if (ddlModules.SelectedValue.ToString() == "Precipitation")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Air_Temperature")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.temperatureSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Relative_Humidity")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Dew_Point")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.relHumiditySources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Solar_Radiation")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.solarRadiationSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Wind")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.windSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Surface_Runoff")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Subsurface_Flow")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.precipSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Soil_Moisture")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.soilMoistureSources));
            }
            else if (ddlModules.SelectedValue.ToString() == "Evapotranspiration")
            {
                ddlSource.DataSource = Enum.GetValues(typeof(Globals.evapotranspirationSources));
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clearDataViews();
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

        private string getData() //This function makes the request action
        {
            DataTable dt = null;
            string URL = "";

            RequestBody requestBody = new RequestBody();

            /* This switch method is changing module specific parameters such as request URL and data source.
               Refer to "Globals.cs" to view the URL path */

            switch (ddlModules.SelectedValue.ToString())
            {
                case "Precipitation":
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.precipitaionURL;
                    break;
                
                case "Air_Temperature":
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.temperatureURL;
                    break;

                case "Relative_Humidity":
                    requestBody.relative = true;
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.relHumidityURL;
                    break;

                case "Dew_Point":
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.dewPointURL;
                    break;

                case "Solar_Radiation":
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.solarRadiationURL;
                    break;

                case "Wind":
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    URL = Globals.baseURL + Globals.windURL;
                    break;

                case "Surface_Runoff":
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
                    requestBody.source = ddlSource.SelectedItem.ToString();
                    requestBody.layers = new string[] { ddlLayerDepth.SelectedItem.ToString().Replace("From", "").Replace("To", "-"), "10-40" }; 
                    URL = Globals.baseURL + Globals.soilMoistureURL;
                    break;

                case "Evapotranspiration":
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
            }


            //Assigning the datetime format and start/end dates
            requestBody.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";
            requestBody.dateTimeSpan.dateTimeFormat = null;
            requestBody.dateTimeSpan.endDate = txtEndDate.Text + "T00:00:00";
            requestBody.dateTimeSpan.startDate = txtStartDate.Text + "T00:00:00"; //  "2015 -01-01T00:00:00";

            requestBody.geometry.geometryMetadata = null;
            requestBody.geometry.timezone = null;

            //Setting request body paramaters based on Area of Interest options
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


            //Assigning the request body time format parameters
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
            
            //Assigning request body remaining parameters
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
                metaDataForExport.Add(mLabel.ToString());
                mLabel.ToObject<JProperty>();
                string item = mLabel.ToObject<JProperty>().Name;
                System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("column_[1-9]|[10]");
                if ((rgx.IsMatch(item)) && (item.Length < 10))
                {
                    dr["Item"] = item.Trim();
                    string val = mLabel.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    dr["Value"] = val;
                    dtMetaData.Rows.Add(dr);
                    //dt.Columns.Add(val);
                    if(item.Length > 8)
                    {
                        item = item.Insert(7, "99");
                    }
                    if ((val == "DateHour") || (val == "Date"))
                    {
                        item = item.Insert(7, "00");
                    }
                    if (val == "Julian Day")
                    {
                        item = item.Insert(7, "00");
                    }
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
                dr[colSorted.Values[0]] = date.Trim();
                string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                string[] valSet = val.Split(',');
                var valCount = valSet.Count();

                for (int i = 0; i < valCount; i++)
                {
                    dr[colSorted.Values[i+1]] = valSet[i];
                }
                dt.Rows.Add(dr);
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
                myStream.WriteLine(txtInputRequest.Text);
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

     
        //This function allows the user to save output data when clicked
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

        private void lnkWorkFlows_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WorkflowNavigator frm = new WorkflowNavigator();
            frm.ShowDialog();
        }

        private void hlpModules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("To run this program, start by selecting a module from the drop-down list.\nNext, "
                + "select the desired parameters and fill out all the text boxes.\n"
                + "Finally, press the 'Submit Request' button to view the output data");
        }

        private void chkCustomRequestInput_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomRequestInput.Checked == true)
            {
                clearDataViews();
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
                btnImportInput.Visible = true;
                btnSumbitCustomInput.Visible = true;
                btnSubmitPrecip.Visible = false;
            }
            else
            {
                btnImportInput.Visible = false;
                btnSumbitCustomInput.Visible = false;
            }
        }

        private void btnImportInput_Click(object sender, EventArgs e)
        {
            clearDataViews();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string content = null;
                content = File.ReadAllText(openFileDialog1.FileName);
                txtInputRequest.Text = content;

            }
        }

        private void btnSumbitCustomInput_Click(object sender, EventArgs e)
        {

            string strResponse = "";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                strResponse = getDataFromCustomRequest();
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

        private string getDataFromCustomRequest ()
        {
            DataTable dt = null;
            string URL = "";
            switch (ddlModules.SelectedValue.ToString())
            {
                case "Precipitation":
                    URL = Globals.baseURL + Globals.precipitaionURL;
                    break;

                case "Air_Temperature":
                    URL = Globals.baseURL + Globals.temperatureURL;
                    break;

                case "Relative_Humidity":
                    URL = Globals.baseURL + Globals.relHumidityURL;
                    break;

                case "Dew_Point":
                    URL = Globals.baseURL + Globals.dewPointURL;
                    break;

                case "Solar_Radiation":
                    URL = Globals.baseURL + Globals.solarRadiationURL;
                    break;

                case "Wind":
                    URL = Globals.baseURL + Globals.windURL;
                    break;

                case "Surface_Runoff":
                    URL = Globals.baseURL + Globals.surfaceRunoffURL;
                    break;

                case "Subsurface_Flow":
                    URL = Globals.baseURL + Globals.subsurfaceFlowURL;
                    break;

                case "Soil_Moisture":
                    URL = Globals.baseURL + Globals.soilMoistureURL;
                    break;

                case "Evapotranspiration":
                    URL = Globals.baseURL + Globals.evapotranspirationURL;
                    break;
            }

            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Clear();
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"*/*";

            var data = Encoding.ASCII.GetBytes(txtInputRequest.Text);
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
                metaDataForExport.Add(mLabel.ToString());
                mLabel.ToObject<JProperty>();
                string item = mLabel.ToObject<JProperty>().Name;
                System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("column_[1-9]|[10]");
                if ((rgx.IsMatch(item)) && (item.Length < 10))
                {
                    dr["Item"] = item.Trim();
                    string val = mLabel.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                    dr["Value"] = val;
                    dtMetaData.Rows.Add(dr);
                    if (item.Length > 8)
                    {
                        item = item.Insert(7, "99");
                    }
                    if ((val == "DateHour") || (val == "Date"))
                    {
                        item = item.Insert(7, "00");
                    }
                    if (val == "Julian Day")
                    {
                        item = item.Insert(7, "00");
                    }
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
                dr[colSorted.Values[0]] = date.Trim();
                string val = item.ToObject<JProperty>().Value.ToString().Replace("\r\n", "").Replace("[ ", "").Replace("]", "").Replace("\"", "").Trim();
                string[] valSet = val.Split(',');
                var valCount = valSet.Count();

                for (int i = 0; i < valCount; i++)
                {
                    dr[colSorted.Values[i + 1]] = valSet[i];
                }
                dt.Rows.Add(dr);
            }

            dgvOutputs.DataSource = dt.DefaultView;
            return responseString;
        }
    }
}
