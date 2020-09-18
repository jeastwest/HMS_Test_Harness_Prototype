namespace HMS_Desktop_Mgr
{
    partial class Streamflow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Streamflow));
            this.pnlAlgorithm = new System.Windows.Forms.Panel();
            this.txtAlgorithm = new System.Windows.Forms.Label();
            this.ddlAlgorithm = new System.Windows.Forms.ComboBox();
            this.pnlTemporalResolution = new System.Windows.Forms.Panel();
            this.ddlTemporalResolution = new System.Windows.Forms.ComboBox();
            this.lblTemporalResolution = new System.Windows.Forms.Label();
            this.pnlTimeSpan = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pnlPrecipSource = new System.Windows.Forms.Panel();
            this.ddlPrecipSource = new System.Windows.Forms.ComboBox();
            this.lblPrecipSource = new System.Windows.Forms.Label();
            this.lblAOI = new System.Windows.Forms.Label();
            this.ddlAOI = new System.Windows.Forms.ComboBox();
            this.txtCOMIDandHucID = new System.Windows.Forms.TextBox();
            this.lblCOMIDandHucID = new System.Windows.Forms.Label();
            this.rTxtUnformattedOutput = new System.Windows.Forms.RichTextBox();
            this.rTxtRequestBody = new System.Windows.Forms.RichTextBox();
            this.lblRequestBody = new System.Windows.Forms.Label();
            this.lblUnformattedOutput = new System.Windows.Forms.Label();
            this.btnSubmitStreamflow = new System.Windows.Forms.Button();
            this.pnlStreamHydrologyAlgorithm = new System.Windows.Forms.Panel();
            this.ddlStreamHydrologyAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblStreamHydrologyAlgorithm = new System.Windows.Forms.Label();
            this.dgvOutputs = new System.Windows.Forms.DataGridView();
            this.lblDgvOutputs = new System.Windows.Forms.Label();
            this.btnSaveMetaData = new System.Windows.Forms.Button();
            this.btnSaveInputData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.pnlAlgorithm.SuspendLayout();
            this.pnlTemporalResolution.SuspendLayout();
            this.pnlTimeSpan.SuspendLayout();
            this.pnlPrecipSource.SuspendLayout();
            this.pnlStreamHydrologyAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlgorithm
            // 
            this.pnlAlgorithm.Controls.Add(this.txtAlgorithm);
            this.pnlAlgorithm.Controls.Add(this.ddlAlgorithm);
            this.pnlAlgorithm.Location = new System.Drawing.Point(15, 85);
            this.pnlAlgorithm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlAlgorithm.Name = "pnlAlgorithm";
            this.pnlAlgorithm.Size = new System.Drawing.Size(376, 43);
            this.pnlAlgorithm.TabIndex = 37;
            // 
            // txtAlgorithm
            // 
            this.txtAlgorithm.AutoSize = true;
            this.txtAlgorithm.Location = new System.Drawing.Point(34, 11);
            this.txtAlgorithm.Name = "txtAlgorithm";
            this.txtAlgorithm.Size = new System.Drawing.Size(136, 20);
            this.txtAlgorithm.TabIndex = 1;
            this.txtAlgorithm.Text = "Runoff Algorithim:";
            // 
            // ddlAlgorithm
            // 
            this.ddlAlgorithm.FormattingEnabled = true;
            this.ddlAlgorithm.Location = new System.Drawing.Point(230, 8);
            this.ddlAlgorithm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ddlAlgorithm.Name = "ddlAlgorithm";
            this.ddlAlgorithm.Size = new System.Drawing.Size(136, 28);
            this.ddlAlgorithm.TabIndex = 0;
            this.ddlAlgorithm.SelectedIndexChanged += new System.EventHandler(this.ddlAlgorithm_SelectedIndexChanged);
            // 
            // pnlTemporalResolution
            // 
            this.pnlTemporalResolution.Controls.Add(this.ddlTemporalResolution);
            this.pnlTemporalResolution.Controls.Add(this.lblTemporalResolution);
            this.pnlTemporalResolution.Location = new System.Drawing.Point(15, 186);
            this.pnlTemporalResolution.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTemporalResolution.Name = "pnlTemporalResolution";
            this.pnlTemporalResolution.Size = new System.Drawing.Size(234, 68);
            this.pnlTemporalResolution.TabIndex = 35;
            // 
            // ddlTemporalResolution
            // 
            this.ddlTemporalResolution.FormattingEnabled = true;
            this.ddlTemporalResolution.Location = new System.Drawing.Point(64, 35);
            this.ddlTemporalResolution.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ddlTemporalResolution.Name = "ddlTemporalResolution";
            this.ddlTemporalResolution.Size = new System.Drawing.Size(96, 28);
            this.ddlTemporalResolution.TabIndex = 1;
            // 
            // lblTemporalResolution
            // 
            this.lblTemporalResolution.AutoSize = true;
            this.lblTemporalResolution.Location = new System.Drawing.Point(4, 11);
            this.lblTemporalResolution.Name = "lblTemporalResolution";
            this.lblTemporalResolution.Size = new System.Drawing.Size(159, 20);
            this.lblTemporalResolution.TabIndex = 0;
            this.lblTemporalResolution.Text = "Temporal Resolution:";
            // 
            // pnlTimeSpan
            // 
            this.pnlTimeSpan.Controls.Add(this.txtEndDate);
            this.pnlTimeSpan.Controls.Add(this.txtStartDate);
            this.pnlTimeSpan.Controls.Add(this.lblStartDate);
            this.pnlTimeSpan.Controls.Add(this.lblEndDate);
            this.pnlTimeSpan.Location = new System.Drawing.Point(255, 186);
            this.pnlTimeSpan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTimeSpan.Name = "pnlTimeSpan";
            this.pnlTimeSpan.Size = new System.Drawing.Size(268, 86);
            this.pnlTimeSpan.TabIndex = 33;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(92, 48);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(142, 26);
            this.txtEndDate.TabIndex = 3;
            this.txtEndDate.Text = "2015-01-31";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(92, 9);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(142, 26);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.Text = "2015-01-01";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(5, 51);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(81, 20);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // pnlPrecipSource
            // 
            this.pnlPrecipSource.Controls.Add(this.ddlPrecipSource);
            this.pnlPrecipSource.Controls.Add(this.lblPrecipSource);
            this.pnlPrecipSource.Location = new System.Drawing.Point(15, 135);
            this.pnlPrecipSource.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlPrecipSource.Name = "pnlPrecipSource";
            this.pnlPrecipSource.Size = new System.Drawing.Size(376, 42);
            this.pnlPrecipSource.TabIndex = 28;
            // 
            // ddlPrecipSource
            // 
            this.ddlPrecipSource.FormattingEnabled = true;
            this.ddlPrecipSource.Location = new System.Drawing.Point(230, 8);
            this.ddlPrecipSource.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ddlPrecipSource.Name = "ddlPrecipSource";
            this.ddlPrecipSource.Size = new System.Drawing.Size(136, 28);
            this.ddlPrecipSource.TabIndex = 1;
            // 
            // lblPrecipSource
            // 
            this.lblPrecipSource.AutoSize = true;
            this.lblPrecipSource.Location = new System.Drawing.Point(34, 11);
            this.lblPrecipSource.Name = "lblPrecipSource";
            this.lblPrecipSource.Size = new System.Drawing.Size(155, 20);
            this.lblPrecipSource.TabIndex = 0;
            this.lblPrecipSource.Text = "Precipitation Source:";
            // 
            // lblAOI
            // 
            this.lblAOI.AutoSize = true;
            this.lblAOI.Location = new System.Drawing.Point(55, 18);
            this.lblAOI.Name = "lblAOI";
            this.lblAOI.Size = new System.Drawing.Size(183, 20);
            this.lblAOI.TabIndex = 30;
            this.lblAOI.Text = "Area of Interest Options:";
            // 
            // ddlAOI
            // 
            this.ddlAOI.FormattingEnabled = true;
            this.ddlAOI.Location = new System.Drawing.Point(244, 15);
            this.ddlAOI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ddlAOI.Name = "ddlAOI";
            this.ddlAOI.Size = new System.Drawing.Size(136, 28);
            this.ddlAOI.TabIndex = 29;
            this.ddlAOI.SelectedIndexChanged += new System.EventHandler(this.ddlAOI_SelectedIndexChanged);
            // 
            // txtCOMIDandHucID
            // 
            this.txtCOMIDandHucID.Location = new System.Drawing.Point(244, 52);
            this.txtCOMIDandHucID.Name = "txtCOMIDandHucID";
            this.txtCOMIDandHucID.Size = new System.Drawing.Size(136, 26);
            this.txtCOMIDandHucID.TabIndex = 38;
            // 
            // lblCOMIDandHucID
            // 
            this.lblCOMIDandHucID.AutoSize = true;
            this.lblCOMIDandHucID.Location = new System.Drawing.Point(64, 55);
            this.lblCOMIDandHucID.Name = "lblCOMIDandHucID";
            this.lblCOMIDandHucID.Size = new System.Drawing.Size(63, 20);
            this.lblCOMIDandHucID.TabIndex = 39;
            this.lblCOMIDandHucID.Text = "Huc ID:";
            // 
            // rTxtUnformattedOutput
            // 
            this.rTxtUnformattedOutput.Location = new System.Drawing.Point(588, 32);
            this.rTxtUnformattedOutput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rTxtUnformattedOutput.Name = "rTxtUnformattedOutput";
            this.rTxtUnformattedOutput.Size = new System.Drawing.Size(370, 329);
            this.rTxtUnformattedOutput.TabIndex = 41;
            this.rTxtUnformattedOutput.Text = "";
            // 
            // rTxtRequestBody
            // 
            this.rTxtRequestBody.Location = new System.Drawing.Point(14, 355);
            this.rTxtRequestBody.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rTxtRequestBody.Name = "rTxtRequestBody";
            this.rTxtRequestBody.Size = new System.Drawing.Size(530, 229);
            this.rTxtRequestBody.TabIndex = 40;
            this.rTxtRequestBody.Text = "";
            // 
            // lblRequestBody
            // 
            this.lblRequestBody.AutoSize = true;
            this.lblRequestBody.Location = new System.Drawing.Point(196, 340);
            this.lblRequestBody.Name = "lblRequestBody";
            this.lblRequestBody.Size = new System.Drawing.Size(110, 20);
            this.lblRequestBody.TabIndex = 42;
            this.lblRequestBody.Text = "Request Body";
            // 
            // lblUnformattedOutput
            // 
            this.lblUnformattedOutput.AutoSize = true;
            this.lblUnformattedOutput.Location = new System.Drawing.Point(705, 18);
            this.lblUnformattedOutput.Name = "lblUnformattedOutput";
            this.lblUnformattedOutput.Size = new System.Drawing.Size(152, 20);
            this.lblUnformattedOutput.TabIndex = 43;
            this.lblUnformattedOutput.Text = "Unformatted Output";
            // 
            // btnSubmitStreamflow
            // 
            this.btnSubmitStreamflow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitStreamflow.Location = new System.Drawing.Point(316, 292);
            this.btnSubmitStreamflow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSubmitStreamflow.Name = "btnSubmitStreamflow";
            this.btnSubmitStreamflow.Size = new System.Drawing.Size(189, 38);
            this.btnSubmitStreamflow.TabIndex = 44;
            this.btnSubmitStreamflow.Text = "Submit Request";
            this.btnSubmitStreamflow.UseVisualStyleBackColor = false;
            this.btnSubmitStreamflow.Click += new System.EventHandler(this.btnSubmitStreamflow_Click);
            // 
            // pnlStreamHydrologyAlgorithm
            // 
            this.pnlStreamHydrologyAlgorithm.Controls.Add(this.ddlStreamHydrologyAlgorithm);
            this.pnlStreamHydrologyAlgorithm.Controls.Add(this.lblStreamHydrologyAlgorithm);
            this.pnlStreamHydrologyAlgorithm.Location = new System.Drawing.Point(14, 262);
            this.pnlStreamHydrologyAlgorithm.Name = "pnlStreamHydrologyAlgorithm";
            this.pnlStreamHydrologyAlgorithm.Size = new System.Drawing.Size(236, 78);
            this.pnlStreamHydrologyAlgorithm.TabIndex = 45;
            // 
            // ddlStreamHydrologyAlgorithm
            // 
            this.ddlStreamHydrologyAlgorithm.FormattingEnabled = true;
            this.ddlStreamHydrologyAlgorithm.Location = new System.Drawing.Point(14, 38);
            this.ddlStreamHydrologyAlgorithm.Name = "ddlStreamHydrologyAlgorithm";
            this.ddlStreamHydrologyAlgorithm.Size = new System.Drawing.Size(202, 28);
            this.ddlStreamHydrologyAlgorithm.TabIndex = 1;
            // 
            // lblStreamHydrologyAlgorithm
            // 
            this.lblStreamHydrologyAlgorithm.AutoSize = true;
            this.lblStreamHydrologyAlgorithm.Location = new System.Drawing.Point(10, 12);
            this.lblStreamHydrologyAlgorithm.Name = "lblStreamHydrologyAlgorithm";
            this.lblStreamHydrologyAlgorithm.Size = new System.Drawing.Size(210, 20);
            this.lblStreamHydrologyAlgorithm.TabIndex = 0;
            this.lblStreamHydrologyAlgorithm.Text = "Stream Hydrology Algorithm:";
            // 
            // dgvOutputs
            // 
            this.dgvOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputs.Location = new System.Drawing.Point(978, 32);
            this.dgvOutputs.Name = "dgvOutputs";
            this.dgvOutputs.RowHeadersWidth = 62;
            this.dgvOutputs.RowTemplate.Height = 28;
            this.dgvOutputs.Size = new System.Drawing.Size(766, 551);
            this.dgvOutputs.TabIndex = 46;
            // 
            // lblDgvOutputs
            // 
            this.lblDgvOutputs.AutoSize = true;
            this.lblDgvOutputs.Location = new System.Drawing.Point(1342, 18);
            this.lblDgvOutputs.Name = "lblDgvOutputs";
            this.lblDgvOutputs.Size = new System.Drawing.Size(87, 20);
            this.lblDgvOutputs.TabIndex = 47;
            this.lblDgvOutputs.Text = "Data Table";
            // 
            // btnSaveMetaData
            // 
            this.btnSaveMetaData.Location = new System.Drawing.Point(661, 461);
            this.btnSaveMetaData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveMetaData.Name = "btnSaveMetaData";
            this.btnSaveMetaData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveMetaData.TabIndex = 50;
            this.btnSaveMetaData.Text = "Save Meta Data";
            this.btnSaveMetaData.UseVisualStyleBackColor = true;
            this.btnSaveMetaData.Click += new System.EventHandler(this.btnSaveMetaData_Click);
            // 
            // btnSaveInputData
            // 
            this.btnSaveInputData.Location = new System.Drawing.Point(661, 406);
            this.btnSaveInputData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveInputData.Name = "btnSaveInputData";
            this.btnSaveInputData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveInputData.TabIndex = 49;
            this.btnSaveInputData.Text = "Save Input Data";
            this.btnSaveInputData.UseVisualStyleBackColor = true;
            this.btnSaveInputData.Click += new System.EventHandler(this.btnSaveInputData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(661, 516);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveData.TabIndex = 48;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // Streamflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 595);
            this.Controls.Add(this.btnSaveMetaData);
            this.Controls.Add(this.btnSaveInputData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lblDgvOutputs);
            this.Controls.Add(this.dgvOutputs);
            this.Controls.Add(this.pnlStreamHydrologyAlgorithm);
            this.Controls.Add(this.btnSubmitStreamflow);
            this.Controls.Add(this.lblUnformattedOutput);
            this.Controls.Add(this.lblRequestBody);
            this.Controls.Add(this.rTxtUnformattedOutput);
            this.Controls.Add(this.rTxtRequestBody);
            this.Controls.Add(this.lblCOMIDandHucID);
            this.Controls.Add(this.txtCOMIDandHucID);
            this.Controls.Add(this.pnlAlgorithm);
            this.Controls.Add(this.pnlTemporalResolution);
            this.Controls.Add(this.pnlTimeSpan);
            this.Controls.Add(this.pnlPrecipSource);
            this.Controls.Add(this.lblAOI);
            this.Controls.Add(this.ddlAOI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Streamflow";
            this.Text = "Streamflow";
            this.Load += new System.EventHandler(this.Streamflow_Load);
            this.pnlAlgorithm.ResumeLayout(false);
            this.pnlAlgorithm.PerformLayout();
            this.pnlTemporalResolution.ResumeLayout(false);
            this.pnlTemporalResolution.PerformLayout();
            this.pnlTimeSpan.ResumeLayout(false);
            this.pnlTimeSpan.PerformLayout();
            this.pnlPrecipSource.ResumeLayout(false);
            this.pnlPrecipSource.PerformLayout();
            this.pnlStreamHydrologyAlgorithm.ResumeLayout(false);
            this.pnlStreamHydrologyAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAlgorithm;
        private System.Windows.Forms.Label txtAlgorithm;
        private System.Windows.Forms.ComboBox ddlAlgorithm;
        private System.Windows.Forms.Panel pnlTemporalResolution;
        private System.Windows.Forms.ComboBox ddlTemporalResolution;
        private System.Windows.Forms.Label lblTemporalResolution;
        private System.Windows.Forms.Panel pnlTimeSpan;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel pnlPrecipSource;
        private System.Windows.Forms.ComboBox ddlPrecipSource;
        private System.Windows.Forms.Label lblPrecipSource;
        private System.Windows.Forms.Label lblAOI;
        private System.Windows.Forms.ComboBox ddlAOI;
        private System.Windows.Forms.TextBox txtCOMIDandHucID;
        private System.Windows.Forms.Label lblCOMIDandHucID;
        private System.Windows.Forms.RichTextBox rTxtUnformattedOutput;
        private System.Windows.Forms.RichTextBox rTxtRequestBody;
        private System.Windows.Forms.Label lblRequestBody;
        private System.Windows.Forms.Label lblUnformattedOutput;
        private System.Windows.Forms.Button btnSubmitStreamflow;
        private System.Windows.Forms.Panel pnlStreamHydrologyAlgorithm;
        private System.Windows.Forms.ComboBox ddlStreamHydrologyAlgorithm;
        private System.Windows.Forms.Label lblStreamHydrologyAlgorithm;
        private System.Windows.Forms.DataGridView dgvOutputs;
        private System.Windows.Forms.Label lblDgvOutputs;
        private System.Windows.Forms.Button btnSaveMetaData;
        private System.Windows.Forms.Button btnSaveInputData;
        private System.Windows.Forms.Button btnSaveData;
    }
}