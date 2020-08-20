namespace HMS_Desktop_Mgr
{
    partial class WorkflowNavigator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkPrecipExtract = new System.Windows.Forms.LinkLabel();
            this.lblPrecipitationDataComparison = new System.Windows.Forms.LinkLabel();
            this.lblPrecipNavigation = new System.Windows.Forms.Label();
            this.lnkStreamflow = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkPrecipExtract
            // 
            this.lnkPrecipExtract.AutoSize = true;
            this.lnkPrecipExtract.Location = new System.Drawing.Point(194, 88);
            this.lnkPrecipExtract.Name = "lnkPrecipExtract";
            this.lnkPrecipExtract.Size = new System.Drawing.Size(207, 20);
            this.lnkPrecipExtract.TabIndex = 0;
            this.lnkPrecipExtract.TabStop = true;
            this.lnkPrecipExtract.Text = "Preciptation Data Extraction";
            this.lnkPrecipExtract.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrecipExtract_LinkClicked);
            // 
            // lblPrecipitationDataComparison
            // 
            this.lblPrecipitationDataComparison.AutoSize = true;
            this.lblPrecipitationDataComparison.Location = new System.Drawing.Point(194, 129);
            this.lblPrecipitationDataComparison.Name = "lblPrecipitationDataComparison";
            this.lblPrecipitationDataComparison.Size = new System.Drawing.Size(185, 20);
            this.lblPrecipitationDataComparison.TabIndex = 1;
            this.lblPrecipitationDataComparison.TabStop = true;
            this.lblPrecipitationDataComparison.Text = "Precipitation Comparison";
            this.lblPrecipitationDataComparison.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPrecipitationDataComparison_LinkClicked);
            // 
            // lblPrecipNavigation
            // 
            this.lblPrecipNavigation.AutoSize = true;
            this.lblPrecipNavigation.Location = new System.Drawing.Point(204, 42);
            this.lblPrecipNavigation.Name = "lblPrecipNavigation";
            this.lblPrecipNavigation.Size = new System.Drawing.Size(136, 20);
            this.lblPrecipNavigation.TabIndex = 2;
            this.lblPrecipNavigation.Text = "Select a Workflow";
            // 
            // lnkStreamflow
            // 
            this.lnkStreamflow.AutoSize = true;
            this.lnkStreamflow.Location = new System.Drawing.Point(194, 177);
            this.lnkStreamflow.Name = "lnkStreamflow";
            this.lnkStreamflow.Size = new System.Drawing.Size(89, 20);
            this.lnkStreamflow.TabIndex = 3;
            this.lnkStreamflow.TabStop = true;
            this.lnkStreamflow.Text = "Streamflow";
            this.lnkStreamflow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStreamflow_LinkClicked);
            // 
            // WorkflowNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lnkStreamflow);
            this.Controls.Add(this.lblPrecipNavigation);
            this.Controls.Add(this.lblPrecipitationDataComparison);
            this.Controls.Add(this.lnkPrecipExtract);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkflowNavigator";
            this.Text = "WorkflowNavigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPrecipExtract;
        private System.Windows.Forms.LinkLabel lblPrecipitationDataComparison;
        private System.Windows.Forms.Label lblPrecipNavigation;
        private System.Windows.Forms.LinkLabel lnkStreamflow;
    }
}