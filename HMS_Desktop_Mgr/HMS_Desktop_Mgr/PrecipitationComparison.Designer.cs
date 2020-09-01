namespace HMS_Desktop_Mgr
{
    partial class PrecipitationComparison
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
            this.btnNHDplusCOMID = new System.Windows.Forms.RadioButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.pnlStationID = new System.Windows.Forms.Panel();
            this.txtNCEIStation = new System.Windows.Forms.TextBox();
            this.lblNCEIInput = new System.Windows.Forms.Label();
            this.chkNCEIStationID = new System.Windows.Forms.CheckBox();
            this.chkSpatialAverage = new System.Windows.Forms.CheckBox();
            this.txtNCEIStationID = new System.Windows.Forms.TextBox();
            this.txtNHDplusCOMID = new System.Windows.Forms.TextBox();
            this.btnNCEI = new System.Windows.Forms.RadioButton();
            this.pnlTemporal = new System.Windows.Forms.Panel();
            this.txtDailyPrecipThreshold = new System.Windows.Forms.TextBox();
            this.txtTotalPrecip = new System.Windows.Forms.TextBox();
            this.lblDailyPrecipThreshold = new System.Windows.Forms.Label();
            this.lbl5DayPrecipThreshold = new System.Windows.Forms.Label();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.lblTemporalAggregation = new System.Windows.Forms.Label();
            this.lblEndYear = new System.Windows.Forms.Label();
            this.lblStartYear = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.RadioButton();
            this.btnDaily = new System.Windows.Forms.RadioButton();
            this.btnExtremePrecip = new System.Windows.Forms.RadioButton();
            this.btnAnnual = new System.Windows.Forms.RadioButton();
            this.lblTemporal = new System.Windows.Forms.Label();
            this.pnlDataSources = new System.Windows.Forms.Panel();
            this.cBoxTRMM = new System.Windows.Forms.CheckBox();
            this.cBoxGLDAS = new System.Windows.Forms.CheckBox();
            this.cBoxNLDAS = new System.Windows.Forms.CheckBox();
            this.lblDataSources = new System.Windows.Forms.Label();
            this.rTxtRequestBody = new System.Windows.Forms.RichTextBox();
            this.rTxtUnformattedOutput = new System.Windows.Forms.RichTextBox();
            this.lblUnformattedOutput = new System.Windows.Forms.Label();
            this.lblRequestBody = new System.Windows.Forms.Label();
            this.btnSubmitPrecipExtract = new System.Windows.Forms.Button();
            this.dgvOutputs = new System.Windows.Forms.DataGridView();
            this.lblDataTable = new System.Windows.Forms.Label();
            this.btnSaveMetaData = new System.Windows.Forms.Button();
            this.btnSaveInputData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.pnlLocation.SuspendLayout();
            this.pnlStationID.SuspendLayout();
            this.pnlTemporal.SuspendLayout();
            this.pnlDataSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNHDplusCOMID
            // 
            this.btnNHDplusCOMID.AutoSize = true;
            this.btnNHDplusCOMID.Location = new System.Drawing.Point(13, 39);
            this.btnNHDplusCOMID.Name = "btnNHDplusCOMID";
            this.btnNHDplusCOMID.Size = new System.Drawing.Size(152, 24);
            this.btnNHDplusCOMID.TabIndex = 0;
            this.btnNHDplusCOMID.TabStop = true;
            this.btnNHDplusCOMID.Text = "NHDPlusCOMID";
            this.btnNHDplusCOMID.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLocation.Location = new System.Drawing.Point(184, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 20);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // pnlLocation
            // 
            this.pnlLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLocation.Controls.Add(this.pnlStationID);
            this.pnlLocation.Controls.Add(this.chkNCEIStationID);
            this.pnlLocation.Controls.Add(this.chkSpatialAverage);
            this.pnlLocation.Controls.Add(this.txtNCEIStationID);
            this.pnlLocation.Controls.Add(this.txtNHDplusCOMID);
            this.pnlLocation.Controls.Add(this.btnNCEI);
            this.pnlLocation.Controls.Add(this.btnNHDplusCOMID);
            this.pnlLocation.Controls.Add(this.lblLocation);
            this.pnlLocation.Location = new System.Drawing.Point(29, 24);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(447, 216);
            this.pnlLocation.TabIndex = 2;
            // 
            // pnlStationID
            // 
            this.pnlStationID.Controls.Add(this.txtNCEIStation);
            this.pnlStationID.Controls.Add(this.lblNCEIInput);
            this.pnlStationID.Location = new System.Drawing.Point(62, 121);
            this.pnlStationID.Name = "pnlStationID";
            this.pnlStationID.Size = new System.Drawing.Size(305, 40);
            this.pnlStationID.TabIndex = 7;
            // 
            // txtNCEIStation
            // 
            this.txtNCEIStation.Location = new System.Drawing.Point(111, 8);
            this.txtNCEIStation.Name = "txtNCEIStation";
            this.txtNCEIStation.Size = new System.Drawing.Size(188, 26);
            this.txtNCEIStation.TabIndex = 1;
            this.txtNCEIStation.Text = "GHCND:USW00013874";
            // 
            // lblNCEIInput
            // 
            this.lblNCEIInput.AutoSize = true;
            this.lblNCEIInput.Location = new System.Drawing.Point(3, 11);
            this.lblNCEIInput.Name = "lblNCEIInput";
            this.lblNCEIInput.Size = new System.Drawing.Size(102, 20);
            this.lblNCEIInput.TabIndex = 0;
            this.lblNCEIInput.Text = "NCEI Station";
            // 
            // chkNCEIStationID
            // 
            this.chkNCEIStationID.AutoSize = true;
            this.chkNCEIStationID.Location = new System.Drawing.Point(284, 91);
            this.chkNCEIStationID.Name = "chkNCEIStationID";
            this.chkNCEIStationID.Size = new System.Drawing.Size(149, 24);
            this.chkNCEIStationID.TabIndex = 6;
            this.chkNCEIStationID.Text = "NCEI Station ID\r\n";
            this.chkNCEIStationID.UseVisualStyleBackColor = true;
            this.chkNCEIStationID.CheckedChanged += new System.EventHandler(this.chkNCEIStationID_CheckedChanged);
            // 
            // chkSpatialAverage
            // 
            this.chkSpatialAverage.AutoSize = true;
            this.chkSpatialAverage.Location = new System.Drawing.Point(30, 91);
            this.chkSpatialAverage.Name = "chkSpatialAverage";
            this.chkSpatialAverage.Size = new System.Drawing.Size(248, 24);
            this.chkSpatialAverage.TabIndex = 5;
            this.chkSpatialAverage.Text = "Use weighted Spatial Average";
            this.chkSpatialAverage.UseVisualStyleBackColor = true;
            // 
            // txtNCEIStationID
            // 
            this.txtNCEIStationID.Location = new System.Drawing.Point(166, 179);
            this.txtNCEIStationID.Name = "txtNCEIStationID";
            this.txtNCEIStationID.Size = new System.Drawing.Size(188, 26);
            this.txtNCEIStationID.TabIndex = 4;
            this.txtNCEIStationID.Text = "GHCND:USW00013874";
            // 
            // txtNHDplusCOMID
            // 
            this.txtNHDplusCOMID.Location = new System.Drawing.Point(188, 39);
            this.txtNHDplusCOMID.Name = "txtNHDplusCOMID";
            this.txtNHDplusCOMID.Size = new System.Drawing.Size(179, 26);
            this.txtNHDplusCOMID.TabIndex = 3;
            this.txtNHDplusCOMID.Text = "13891106";
            // 
            // btnNCEI
            // 
            this.btnNCEI.AutoSize = true;
            this.btnNCEI.Location = new System.Drawing.Point(12, 179);
            this.btnNCEI.Name = "btnNCEI";
            this.btnNCEI.Size = new System.Drawing.Size(148, 24);
            this.btnNCEI.TabIndex = 2;
            this.btnNCEI.TabStop = true;
            this.btnNCEI.Text = "NCEI Station ID";
            this.btnNCEI.UseVisualStyleBackColor = true;
            // 
            // pnlTemporal
            // 
            this.pnlTemporal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTemporal.Controls.Add(this.txtDailyPrecipThreshold);
            this.pnlTemporal.Controls.Add(this.txtTotalPrecip);
            this.pnlTemporal.Controls.Add(this.lblDailyPrecipThreshold);
            this.pnlTemporal.Controls.Add(this.lbl5DayPrecipThreshold);
            this.pnlTemporal.Controls.Add(this.txtEndYear);
            this.pnlTemporal.Controls.Add(this.txtStartYear);
            this.pnlTemporal.Controls.Add(this.lblTemporalAggregation);
            this.pnlTemporal.Controls.Add(this.lblEndYear);
            this.pnlTemporal.Controls.Add(this.lblStartYear);
            this.pnlTemporal.Controls.Add(this.btnMonthly);
            this.pnlTemporal.Controls.Add(this.btnDaily);
            this.pnlTemporal.Controls.Add(this.btnExtremePrecip);
            this.pnlTemporal.Controls.Add(this.btnAnnual);
            this.pnlTemporal.Controls.Add(this.lblTemporal);
            this.pnlTemporal.Location = new System.Drawing.Point(29, 246);
            this.pnlTemporal.Name = "pnlTemporal";
            this.pnlTemporal.Size = new System.Drawing.Size(447, 333);
            this.pnlTemporal.TabIndex = 3;
            // 
            // txtDailyPrecipThreshold
            // 
            this.txtDailyPrecipThreshold.Location = new System.Drawing.Point(242, 280);
            this.txtDailyPrecipThreshold.Name = "txtDailyPrecipThreshold";
            this.txtDailyPrecipThreshold.Size = new System.Drawing.Size(100, 26);
            this.txtDailyPrecipThreshold.TabIndex = 13;
            this.txtDailyPrecipThreshold.Text = "0";
            // 
            // txtTotalPrecip
            // 
            this.txtTotalPrecip.Location = new System.Drawing.Point(284, 244);
            this.txtTotalPrecip.Name = "txtTotalPrecip";
            this.txtTotalPrecip.Size = new System.Drawing.Size(100, 26);
            this.txtTotalPrecip.TabIndex = 12;
            this.txtTotalPrecip.Text = "0";
            // 
            // lblDailyPrecipThreshold
            // 
            this.lblDailyPrecipThreshold.AutoSize = true;
            this.lblDailyPrecipThreshold.Location = new System.Drawing.Point(14, 283);
            this.lblDailyPrecipThreshold.Name = "lblDailyPrecipThreshold";
            this.lblDailyPrecipThreshold.Size = new System.Drawing.Size(222, 20);
            this.lblDailyPrecipThreshold.TabIndex = 11;
            this.lblDailyPrecipThreshold.Text = "Daily precip threshold (mm) >=";
            // 
            // lbl5DayPrecipThreshold
            // 
            this.lbl5DayPrecipThreshold.AutoSize = true;
            this.lbl5DayPrecipThreshold.Location = new System.Drawing.Point(14, 247);
            this.lbl5DayPrecipThreshold.Name = "lbl5DayPrecipThreshold";
            this.lbl5DayPrecipThreshold.Size = new System.Drawing.Size(264, 20);
            this.lbl5DayPrecipThreshold.TabIndex = 10;
            this.lbl5DayPrecipThreshold.Text = "5 Day total precip threshold (mm) >=";
            // 
            // txtEndYear
            // 
            this.txtEndYear.Location = new System.Drawing.Point(257, 36);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(100, 26);
            this.txtEndYear.TabIndex = 9;
            this.txtEndYear.Text = "2012";
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(76, 36);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(100, 26);
            this.txtStartYear.TabIndex = 8;
            this.txtStartYear.Text = "2010";
            // 
            // lblTemporalAggregation
            // 
            this.lblTemporalAggregation.AutoSize = true;
            this.lblTemporalAggregation.Location = new System.Drawing.Point(14, 84);
            this.lblTemporalAggregation.Name = "lblTemporalAggregation";
            this.lblTemporalAggregation.Size = new System.Drawing.Size(363, 20);
            this.lblTemporalAggregation.TabIndex = 7;
            this.lblTemporalAggregation.Text = "Temporal Aggregation (select one of the following)";
            // 
            // lblEndYear
            // 
            this.lblEndYear.AutoSize = true;
            this.lblEndYear.Location = new System.Drawing.Point(265, 16);
            this.lblEndYear.Name = "lblEndYear";
            this.lblEndYear.Size = new System.Drawing.Size(76, 20);
            this.lblEndYear.TabIndex = 6;
            this.lblEndYear.Text = "End Year";
            // 
            // lblStartYear
            // 
            this.lblStartYear.AutoSize = true;
            this.lblStartYear.Location = new System.Drawing.Point(83, 16);
            this.lblStartYear.Name = "lblStartYear";
            this.lblStartYear.Size = new System.Drawing.Size(82, 20);
            this.lblStartYear.TabIndex = 5;
            this.lblStartYear.Text = "Start Year";
            // 
            // btnMonthly
            // 
            this.btnMonthly.AutoSize = true;
            this.btnMonthly.Location = new System.Drawing.Point(13, 140);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(89, 24);
            this.btnMonthly.TabIndex = 4;
            this.btnMonthly.TabStop = true;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.UseVisualStyleBackColor = true;
            // 
            // btnDaily
            // 
            this.btnDaily.AutoSize = true;
            this.btnDaily.Location = new System.Drawing.Point(14, 110);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(68, 24);
            this.btnDaily.TabIndex = 3;
            this.btnDaily.TabStop = true;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseVisualStyleBackColor = true;
            // 
            // btnExtremePrecip
            // 
            this.btnExtremePrecip.AutoSize = true;
            this.btnExtremePrecip.Location = new System.Drawing.Point(14, 200);
            this.btnExtremePrecip.Name = "btnExtremePrecip";
            this.btnExtremePrecip.Size = new System.Drawing.Size(186, 24);
            this.btnExtremePrecip.TabIndex = 2;
            this.btnExtremePrecip.TabStop = true;
            this.btnExtremePrecip.Text = "Extreme Precip Event";
            this.btnExtremePrecip.UseVisualStyleBackColor = true;
            // 
            // btnAnnual
            // 
            this.btnAnnual.AutoSize = true;
            this.btnAnnual.Location = new System.Drawing.Point(13, 170);
            this.btnAnnual.Name = "btnAnnual";
            this.btnAnnual.Size = new System.Drawing.Size(84, 24);
            this.btnAnnual.TabIndex = 0;
            this.btnAnnual.TabStop = true;
            this.btnAnnual.Text = "Annual";
            this.btnAnnual.UseVisualStyleBackColor = true;
            // 
            // lblTemporal
            // 
            this.lblTemporal.AutoSize = true;
            this.lblTemporal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTemporal.Location = new System.Drawing.Point(184, 0);
            this.lblTemporal.Name = "lblTemporal";
            this.lblTemporal.Size = new System.Drawing.Size(75, 20);
            this.lblTemporal.TabIndex = 1;
            this.lblTemporal.Text = "Temporal";
            // 
            // pnlDataSources
            // 
            this.pnlDataSources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSources.Controls.Add(this.cBoxTRMM);
            this.pnlDataSources.Controls.Add(this.cBoxGLDAS);
            this.pnlDataSources.Controls.Add(this.cBoxNLDAS);
            this.pnlDataSources.Location = new System.Drawing.Point(29, 585);
            this.pnlDataSources.Name = "pnlDataSources";
            this.pnlDataSources.Size = new System.Drawing.Size(447, 60);
            this.pnlDataSources.TabIndex = 4;
            // 
            // cBoxTRMM
            // 
            this.cBoxTRMM.AutoSize = true;
            this.cBoxTRMM.Location = new System.Drawing.Point(312, 23);
            this.cBoxTRMM.Name = "cBoxTRMM";
            this.cBoxTRMM.Size = new System.Drawing.Size(82, 24);
            this.cBoxTRMM.TabIndex = 4;
            this.cBoxTRMM.Text = "TRMM";
            this.cBoxTRMM.UseVisualStyleBackColor = true;
            // 
            // cBoxGLDAS
            // 
            this.cBoxGLDAS.AutoSize = true;
            this.cBoxGLDAS.Location = new System.Drawing.Point(173, 23);
            this.cBoxGLDAS.Name = "cBoxGLDAS";
            this.cBoxGLDAS.Size = new System.Drawing.Size(91, 24);
            this.cBoxGLDAS.TabIndex = 3;
            this.cBoxGLDAS.Text = "GLDAS";
            this.cBoxGLDAS.UseVisualStyleBackColor = true;
            // 
            // cBoxNLDAS
            // 
            this.cBoxNLDAS.AutoSize = true;
            this.cBoxNLDAS.Location = new System.Drawing.Point(21, 23);
            this.cBoxNLDAS.Name = "cBoxNLDAS";
            this.cBoxNLDAS.Size = new System.Drawing.Size(89, 24);
            this.cBoxNLDAS.TabIndex = 2;
            this.cBoxNLDAS.Text = "NLDAS";
            this.cBoxNLDAS.UseVisualStyleBackColor = true;
            // 
            // lblDataSources
            // 
            this.lblDataSources.AutoSize = true;
            this.lblDataSources.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDataSources.Location = new System.Drawing.Point(198, 582);
            this.lblDataSources.Name = "lblDataSources";
            this.lblDataSources.Size = new System.Drawing.Size(107, 20);
            this.lblDataSources.TabIndex = 1;
            this.lblDataSources.Text = "Data Sources";
            // 
            // rTxtRequestBody
            // 
            this.rTxtRequestBody.Location = new System.Drawing.Point(520, 34);
            this.rTxtRequestBody.Name = "rTxtRequestBody";
            this.rTxtRequestBody.Size = new System.Drawing.Size(431, 201);
            this.rTxtRequestBody.TabIndex = 5;
            this.rTxtRequestBody.Text = "";
            // 
            // rTxtUnformattedOutput
            // 
            this.rTxtUnformattedOutput.Location = new System.Drawing.Point(974, 34);
            this.rTxtUnformattedOutput.Name = "rTxtUnformattedOutput";
            this.rTxtUnformattedOutput.Size = new System.Drawing.Size(428, 201);
            this.rTxtUnformattedOutput.TabIndex = 6;
            this.rTxtUnformattedOutput.Text = "";
            // 
            // lblUnformattedOutput
            // 
            this.lblUnformattedOutput.AutoSize = true;
            this.lblUnformattedOutput.Location = new System.Drawing.Point(1122, 24);
            this.lblUnformattedOutput.Name = "lblUnformattedOutput";
            this.lblUnformattedOutput.Size = new System.Drawing.Size(152, 20);
            this.lblUnformattedOutput.TabIndex = 7;
            this.lblUnformattedOutput.Text = "Unformatted Output";
            // 
            // lblRequestBody
            // 
            this.lblRequestBody.AutoSize = true;
            this.lblRequestBody.Location = new System.Drawing.Point(677, 24);
            this.lblRequestBody.Name = "lblRequestBody";
            this.lblRequestBody.Size = new System.Drawing.Size(110, 20);
            this.lblRequestBody.TabIndex = 8;
            this.lblRequestBody.Text = "Request Body";
            // 
            // btnSubmitPrecipExtract
            // 
            this.btnSubmitPrecipExtract.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitPrecipExtract.Location = new System.Drawing.Point(152, 695);
            this.btnSubmitPrecipExtract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitPrecipExtract.Name = "btnSubmitPrecipExtract";
            this.btnSubmitPrecipExtract.Size = new System.Drawing.Size(177, 39);
            this.btnSubmitPrecipExtract.TabIndex = 13;
            this.btnSubmitPrecipExtract.Text = "Submit Request";
            this.btnSubmitPrecipExtract.UseVisualStyleBackColor = false;
            this.btnSubmitPrecipExtract.Click += new System.EventHandler(this.btnSubmitPrecipExtract_Click);
            // 
            // dgvOutputs
            // 
            this.dgvOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputs.Location = new System.Drawing.Point(520, 273);
            this.dgvOutputs.Name = "dgvOutputs";
            this.dgvOutputs.RowHeadersWidth = 62;
            this.dgvOutputs.RowTemplate.Height = 28;
            this.dgvOutputs.Size = new System.Drawing.Size(628, 490);
            this.dgvOutputs.TabIndex = 14;
            // 
            // lblDataTable
            // 
            this.lblDataTable.AutoSize = true;
            this.lblDataTable.Location = new System.Drawing.Point(770, 262);
            this.lblDataTable.Name = "lblDataTable";
            this.lblDataTable.Size = new System.Drawing.Size(87, 20);
            this.lblDataTable.TabIndex = 15;
            this.lblDataTable.Text = "Data Table";
            // 
            // btnSaveMetaData
            // 
            this.btnSaveMetaData.Location = new System.Drawing.Point(1200, 491);
            this.btnSaveMetaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveMetaData.Name = "btnSaveMetaData";
            this.btnSaveMetaData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveMetaData.TabIndex = 31;
            this.btnSaveMetaData.Text = "Save Meta Data";
            this.btnSaveMetaData.UseVisualStyleBackColor = true;
            this.btnSaveMetaData.Click += new System.EventHandler(this.btnSaveMetaData_Click);
            // 
            // btnSaveInputData
            // 
            this.btnSaveInputData.Location = new System.Drawing.Point(1200, 407);
            this.btnSaveInputData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveInputData.Name = "btnSaveInputData";
            this.btnSaveInputData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveInputData.TabIndex = 30;
            this.btnSaveInputData.Text = "Save Input Data";
            this.btnSaveInputData.UseVisualStyleBackColor = true;
            this.btnSaveInputData.Click += new System.EventHandler(this.btnSaveInputData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(1200, 582);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(184, 45);
            this.btnSaveData.TabIndex = 29;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // PrecipitationComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 775);
            this.Controls.Add(this.btnSaveMetaData);
            this.Controls.Add(this.btnSaveInputData);
            this.Controls.Add(this.lblDataSources);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lblDataTable);
            this.Controls.Add(this.dgvOutputs);
            this.Controls.Add(this.btnSubmitPrecipExtract);
            this.Controls.Add(this.lblRequestBody);
            this.Controls.Add(this.lblUnformattedOutput);
            this.Controls.Add(this.rTxtUnformattedOutput);
            this.Controls.Add(this.rTxtRequestBody);
            this.Controls.Add(this.pnlDataSources);
            this.Controls.Add(this.pnlTemporal);
            this.Controls.Add(this.pnlLocation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrecipitationComparison";
            this.Text = "PrecipitationComparison";
            this.Load += new System.EventHandler(this.PrecipitationComparison_Load);
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlStationID.ResumeLayout(false);
            this.pnlStationID.PerformLayout();
            this.pnlTemporal.ResumeLayout(false);
            this.pnlTemporal.PerformLayout();
            this.pnlDataSources.ResumeLayout(false);
            this.pnlDataSources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnNHDplusCOMID;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.RadioButton btnNCEI;
        private System.Windows.Forms.Panel pnlTemporal;
        private System.Windows.Forms.RadioButton btnMonthly;
        private System.Windows.Forms.RadioButton btnDaily;
        private System.Windows.Forms.RadioButton btnExtremePrecip;
        private System.Windows.Forms.RadioButton btnAnnual;
        private System.Windows.Forms.Label lblTemporal;
        private System.Windows.Forms.Panel pnlDataSources;
        private System.Windows.Forms.Label lblDataSources;
        private System.Windows.Forms.Label lblEndYear;
        private System.Windows.Forms.Label lblStartYear;
        private System.Windows.Forms.Label lblTemporalAggregation;
        private System.Windows.Forms.Panel pnlStationID;
        private System.Windows.Forms.TextBox txtNCEIStation;
        private System.Windows.Forms.Label lblNCEIInput;
        private System.Windows.Forms.CheckBox chkNCEIStationID;
        private System.Windows.Forms.CheckBox chkSpatialAverage;
        private System.Windows.Forms.TextBox txtNCEIStationID;
        private System.Windows.Forms.TextBox txtNHDplusCOMID;
        private System.Windows.Forms.TextBox txtDailyPrecipThreshold;
        private System.Windows.Forms.TextBox txtTotalPrecip;
        private System.Windows.Forms.Label lblDailyPrecipThreshold;
        private System.Windows.Forms.Label lbl5DayPrecipThreshold;
        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.CheckBox cBoxTRMM;
        private System.Windows.Forms.CheckBox cBoxGLDAS;
        private System.Windows.Forms.CheckBox cBoxNLDAS;
        private System.Windows.Forms.RichTextBox rTxtRequestBody;
        private System.Windows.Forms.RichTextBox rTxtUnformattedOutput;
        private System.Windows.Forms.Label lblUnformattedOutput;
        private System.Windows.Forms.Label lblRequestBody;
        private System.Windows.Forms.Button btnSubmitPrecipExtract;
        private System.Windows.Forms.DataGridView dgvOutputs;
        private System.Windows.Forms.Label lblDataTable;
        private System.Windows.Forms.Button btnSaveMetaData;
        private System.Windows.Forms.Button btnSaveInputData;
        private System.Windows.Forms.Button btnSaveData;
    }
}