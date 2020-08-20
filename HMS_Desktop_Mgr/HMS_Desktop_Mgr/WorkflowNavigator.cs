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
    public partial class WorkflowNavigator : Form
    {
        public WorkflowNavigator()
        {
            InitializeComponent();
        }

        private void lnkPrecipExtract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrecipExtract frm = new PrecipExtract();
            frm.ShowDialog();
         }

        private void lblPrecipitationDataComparison_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrecipitationComparison frm = new PrecipitationComparison();
            frm.ShowDialog();
        }

        private void lnkStreamflow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Streamflow frm = new Streamflow();
            frm.ShowDialog();
        }
    }
}
