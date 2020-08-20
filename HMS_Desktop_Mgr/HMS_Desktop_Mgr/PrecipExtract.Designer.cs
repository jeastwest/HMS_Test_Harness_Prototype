namespace HMS_Desktop_Mgr
{
    partial class PrecipExtract
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
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.ddlTemporalResolution = new System.Windows.Forms.ComboBox();
            this.lblPEStationID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTemporalResolution = new System.Windows.Forms.Label();
            this.rTxtRequestBody = new System.Windows.Forms.RichTextBox();
            this.lblRequestBody = new System.Windows.Forms.Label();
            this.rTxtUnformattedOutput = new System.Windows.Forms.RichTextBox();
            this.lblUnformattedOutput = new System.Windows.Forms.Label();
            this.btnSubmitPrecipExtract = new System.Windows.Forms.Button();
            this.dgvPrecipExtractOutputs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecipExtractOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(238, 12);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(100, 22);
            this.txtStationID.TabIndex = 0;
            this.txtStationID.Text = "GHCND:USW00013874";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(238, 40);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 22);
            this.txtStartDate.TabIndex = 1;
            this.txtStartDate.Text = "2010-01-01";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(238, 71);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 22);
            this.txtEndDate.TabIndex = 2;
            this.txtEndDate.Text = "2010-12-31";
            // 
            // ddlTemporalResolution
            // 
            this.ddlTemporalResolution.FormattingEnabled = true;
            this.ddlTemporalResolution.Location = new System.Drawing.Point(238, 99);
            this.ddlTemporalResolution.Name = "ddlTemporalResolution";
            this.ddlTemporalResolution.Size = new System.Drawing.Size(121, 24);
            this.ddlTemporalResolution.TabIndex = 3;
            // 
            // lblPEStationID
            // 
            this.lblPEStationID.AutoSize = true;
            this.lblPEStationID.Location = new System.Drawing.Point(89, 13);
            this.lblPEStationID.Name = "lblPEStationID";
            this.lblPEStationID.Size = new System.Drawing.Size(104, 17);
            this.lblPEStationID.TabIndex = 4;
            this.lblPEStationID.Text = "NCEI StationID:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(89, 40);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(89, 71);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 17);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblTemporalResolution
            // 
            this.lblTemporalResolution.AutoSize = true;
            this.lblTemporalResolution.Location = new System.Drawing.Point(89, 99);
            this.lblTemporalResolution.Name = "lblTemporalResolution";
            this.lblTemporalResolution.Size = new System.Drawing.Size(143, 17);
            this.lblTemporalResolution.TabIndex = 7;
            this.lblTemporalResolution.Text = "Temporal Resolution:";
            // 
            // rTxtRequestBody
            // 
            this.rTxtRequestBody.Location = new System.Drawing.Point(12, 178);
            this.rTxtRequestBody.Name = "rTxtRequestBody";
            this.rTxtRequestBody.Size = new System.Drawing.Size(365, 250);
            this.rTxtRequestBody.TabIndex = 8;
            this.rTxtRequestBody.Text = "";
            // 
            // lblRequestBody
            // 
            this.lblRequestBody.AutoSize = true;
            this.lblRequestBody.Location = new System.Drawing.Point(135, 167);
            this.lblRequestBody.Name = "lblRequestBody";
            this.lblRequestBody.Size = new System.Drawing.Size(97, 17);
            this.lblRequestBody.TabIndex = 9;
            this.lblRequestBody.Text = "Request Body";
            // 
            // rTxtUnformattedOutput
            // 
            this.rTxtUnformattedOutput.Location = new System.Drawing.Point(396, 17);
            this.rTxtUnformattedOutput.Name = "rTxtUnformattedOutput";
            this.rTxtUnformattedOutput.Size = new System.Drawing.Size(392, 136);
            this.rTxtUnformattedOutput.TabIndex = 10;
            this.rTxtUnformattedOutput.Text = "";
            // 
            // lblUnformattedOutput
            // 
            this.lblUnformattedOutput.AutoSize = true;
            this.lblUnformattedOutput.Location = new System.Drawing.Point(523, 9);
            this.lblUnformattedOutput.Name = "lblUnformattedOutput";
            this.lblUnformattedOutput.Size = new System.Drawing.Size(133, 17);
            this.lblUnformattedOutput.TabIndex = 11;
            this.lblUnformattedOutput.Text = "Unformatted Output";
            // 
            // btnSubmitPrecipExtract
            // 
            this.btnSubmitPrecipExtract.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitPrecipExtract.Location = new System.Drawing.Point(138, 129);
            this.btnSubmitPrecipExtract.Name = "btnSubmitPrecipExtract";
            this.btnSubmitPrecipExtract.Size = new System.Drawing.Size(106, 31);
            this.btnSubmitPrecipExtract.TabIndex = 12;
            this.btnSubmitPrecipExtract.Text = "Submit";
            this.btnSubmitPrecipExtract.UseVisualStyleBackColor = false;
            this.btnSubmitPrecipExtract.Click += new System.EventHandler(this.btnSubmitPrecipExtract_Click);
            // 
            // dgvPrecipExtractOutputs
            // 
            this.dgvPrecipExtractOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecipExtractOutputs.Location = new System.Drawing.Point(396, 178);
            this.dgvPrecipExtractOutputs.Name = "dgvPrecipExtractOutputs";
            this.dgvPrecipExtractOutputs.RowHeadersWidth = 51;
            this.dgvPrecipExtractOutputs.RowTemplate.Height = 24;
            this.dgvPrecipExtractOutputs.Size = new System.Drawing.Size(392, 260);
            this.dgvPrecipExtractOutputs.TabIndex = 13;
            // 
            // PrecipExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrecipExtractOutputs);
            this.Controls.Add(this.btnSubmitPrecipExtract);
            this.Controls.Add(this.lblUnformattedOutput);
            this.Controls.Add(this.rTxtUnformattedOutput);
            this.Controls.Add(this.lblRequestBody);
            this.Controls.Add(this.rTxtRequestBody);
            this.Controls.Add(this.lblTemporalResolution);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPEStationID);
            this.Controls.Add(this.ddlTemporalResolution);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtStationID);
            this.Name = "PrecipExtract";
            this.Text = "PrecipExtract";
            this.Load += new System.EventHandler(this.PrecipExtract_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecipExtractOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStationID;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.ComboBox ddlTemporalResolution;
        private System.Windows.Forms.Label lblPEStationID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblTemporalResolution;
        private System.Windows.Forms.RichTextBox rTxtRequestBody;
        private System.Windows.Forms.Label lblRequestBody;
        private System.Windows.Forms.RichTextBox rTxtUnformattedOutput;
        private System.Windows.Forms.Label lblUnformattedOutput;
        private System.Windows.Forms.Button btnSubmitPrecipExtract;
        private System.Windows.Forms.DataGridView dgvPrecipExtractOutputs;
    }
}