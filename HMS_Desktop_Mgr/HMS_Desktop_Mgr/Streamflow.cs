using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ddlTemporalResolution.DataSource = Enum.GetValues(typeof(Globals.TemporalResultionDaily));
            ddlStreamHydrologyAlgorithm.DataSource = Enum.GetValues(typeof(Globals.StreamHydrologyAlgorithms));
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

        //NOTE: The code below is still in development. This code will not work properly at this time.

        private string getData()
        {
            string URL = Globals.baseURL + Globals.streamflowURL;
            RequestBodyStreamflow rbStreamflow = new RequestBodyStreamflow();
            rbStreamflow.dateTimeSpan.dateTimeFormat = "yyyy-MM-dd HH";
            rbStreamflow.dateTimeSpan.endDate = txtEndDate.Text + "T00:00:00";
            rbStreamflow.dateTimeSpan.startDate = txtStartDate.Text + "T00:00:00"; //  "2015 -01-01T00:00:00";

            rbStreamflow.geometry.description = null;
            rbStreamflow.geometry.timezone = null;
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
            }
            else
            {
                rbStreamflow.source = ddlAlgorithm.SelectedItem.ToString();
                rbStreamflow.geometryMetadata.precipSource = ddlPrecipSource.SelectedItem.ToString();
            }
            //filler code DELETE
            return URL;
        }


    }
}
