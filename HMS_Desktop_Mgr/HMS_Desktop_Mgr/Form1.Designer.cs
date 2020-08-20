namespace HMS_Desktop_Mgr
{
    partial class Form1
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
            this.pnlLatLng = new System.Windows.Forms.Panel();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.ddlModules = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ddlAOI = new System.Windows.Forms.ComboBox();
            this.lblAOI = new System.Windows.Forms.Label();
            this.lblCOMID = new System.Windows.Forms.Label();
            this.txtCOMID = new System.Windows.Forms.TextBox();
            this.pnlCOMID = new System.Windows.Forms.Panel();
            this.pnlStationID = new System.Windows.Forms.Panel();
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.lblStationID = new System.Windows.Forms.Label();
            this.pnlSource = new System.Windows.Forms.Panel();
            this.ddlSource = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.pnlTimeSpan = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDataFormat = new System.Windows.Forms.Panel();
            this.lblOutputDataFormat = new System.Windows.Forms.Label();
            this.ddlOutputDataFormat = new System.Windows.Forms.ComboBox();
            this.pnlTemporalResolution = new System.Windows.Forms.Panel();
            this.ddlTemporalResolution = new System.Windows.Forms.ComboBox();
            this.lblTemporalResolution = new System.Windows.Forms.Label();
            this.pnlTimeZone = new System.Windows.Forms.Panel();
            this.ddlTimeZone = new System.Windows.Forms.ComboBox();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.btnSubmitPrecip = new System.Windows.Forms.Button();
            this.pnlOutputs = new System.Windows.Forms.Panel();
            this.txtOutputs = new System.Windows.Forms.RichTextBox();
            this.dgvOutputs = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlAlgorithm = new System.Windows.Forms.Panel();
            this.txtAlgorithm = new System.Windows.Forms.Label();
            this.ddlAlgorithm = new System.Windows.Forms.ComboBox();
            this.txtInputRequest = new System.Windows.Forms.RichTextBox();
            this.lblInputRequest = new System.Windows.Forms.Label();
            this.lblOutputText = new System.Windows.Forms.Label();
            this.lblOutputTable = new System.Windows.Forms.Label();
            this.pnlLayerDepth = new System.Windows.Forms.Panel();
            this.lblLayerDepth = new System.Windows.Forms.Label();
            this.ddlLayerDepth = new System.Windows.Forms.ComboBox();
            this.pnlAlbedo = new System.Windows.Forms.Panel();
            this.txtAlbedo = new System.Windows.Forms.TextBox();
            this.lblAlbedo = new System.Windows.Forms.Label();
            this.btnSaveInputData = new System.Windows.Forms.Button();
            this.btnSaveMetaData = new System.Windows.Forms.Button();
            this.lnkWorkFlows = new System.Windows.Forms.LinkLabel();
            this.pnlLatLng.SuspendLayout();
            this.pnlCOMID.SuspendLayout();
            this.pnlStationID.SuspendLayout();
            this.pnlSource.SuspendLayout();
            this.pnlTimeSpan.SuspendLayout();
            this.pnlDataFormat.SuspendLayout();
            this.pnlTemporalResolution.SuspendLayout();
            this.pnlTimeZone.SuspendLayout();
            this.pnlOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).BeginInit();
            this.pnlAlgorithm.SuspendLayout();
            this.pnlLayerDepth.SuspendLayout();
            this.pnlAlbedo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLatLng
            // 
            this.pnlLatLng.Controls.Add(this.lblLongitude);
            this.pnlLatLng.Controls.Add(this.lblLatitude);
            this.pnlLatLng.Controls.Add(this.txtLongitude);
            this.pnlLatLng.Controls.Add(this.txtLatitude);
            this.pnlLatLng.Location = new System.Drawing.Point(12, 147);
            this.pnlLatLng.Name = "pnlLatLng";
            this.pnlLatLng.Size = new System.Drawing.Size(503, 45);
            this.pnlLatLng.TabIndex = 0;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(281, 21);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(71, 17);
            this.lblLongitude.TabIndex = 3;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(31, 18);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(59, 17);
            this.lblLatitude.TabIndex = 2;
            this.lblLatitude.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(369, 15);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(122, 22);
            this.txtLongitude.TabIndex = 1;
            this.txtLongitude.Text = "-83.356893";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(102, 16);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(132, 22);
            this.txtLatitude.TabIndex = 0;
            this.txtLatitude.Text = "33.925575";
            // 
            // ddlModules
            // 
            this.ddlModules.FormattingEnabled = true;
            this.ddlModules.Location = new System.Drawing.Point(142, 41);
            this.ddlModules.Name = "ddlModules";
            this.ddlModules.Size = new System.Drawing.Size(200, 24);
            this.ddlModules.TabIndex = 1;
            this.ddlModules.SelectedIndexChanged += new System.EventHandler(this.moduleSelection);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Module";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 1;
            // 
            // ddlAOI
            // 
            this.ddlAOI.FormattingEnabled = true;
            this.ddlAOI.Location = new System.Drawing.Point(217, 82);
            this.ddlAOI.Name = "ddlAOI";
            this.ddlAOI.Size = new System.Drawing.Size(121, 24);
            this.ddlAOI.TabIndex = 3;
            this.ddlAOI.SelectedIndexChanged += new System.EventHandler(this.ddlAOI_SelectedIndexChanged);
            // 
            // lblAOI
            // 
            this.lblAOI.AutoSize = true;
            this.lblAOI.Location = new System.Drawing.Point(53, 85);
            this.lblAOI.Name = "lblAOI";
            this.lblAOI.Size = new System.Drawing.Size(158, 17);
            this.lblAOI.TabIndex = 4;
            this.lblAOI.Text = "Area of Interest Options";
            // 
            // lblCOMID
            // 
            this.lblCOMID.AutoSize = true;
            this.lblCOMID.Location = new System.Drawing.Point(15, 5);
            this.lblCOMID.Name = "lblCOMID";
            this.lblCOMID.Size = new System.Drawing.Size(52, 17);
            this.lblCOMID.TabIndex = 5;
            this.lblCOMID.Text = "COMID";
            // 
            // txtCOMID
            // 
            this.txtCOMID.Location = new System.Drawing.Point(89, 5);
            this.txtCOMID.Name = "txtCOMID";
            this.txtCOMID.Size = new System.Drawing.Size(100, 22);
            this.txtCOMID.TabIndex = 6;
            this.txtCOMID.Text = "22076143";
            // 
            // pnlCOMID
            // 
            this.pnlCOMID.Controls.Add(this.lblCOMID);
            this.pnlCOMID.Controls.Add(this.txtCOMID);
            this.pnlCOMID.Location = new System.Drawing.Point(12, 198);
            this.pnlCOMID.Name = "pnlCOMID";
            this.pnlCOMID.Size = new System.Drawing.Size(200, 33);
            this.pnlCOMID.TabIndex = 7;
            // 
            // pnlStationID
            // 
            this.pnlStationID.Controls.Add(this.txtStationID);
            this.pnlStationID.Controls.Add(this.lblStationID);
            this.pnlStationID.Location = new System.Drawing.Point(240, 198);
            this.pnlStationID.Name = "pnlStationID";
            this.pnlStationID.Size = new System.Drawing.Size(275, 33);
            this.pnlStationID.TabIndex = 8;
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(74, 5);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(161, 22);
            this.txtStationID.TabIndex = 1;
            this.txtStationID.Text = "GHCND:USW00013874";
            // 
            // lblStationID
            // 
            this.lblStationID.AutoSize = true;
            this.lblStationID.Location = new System.Drawing.Point(3, 5);
            this.lblStationID.Name = "lblStationID";
            this.lblStationID.Size = new System.Drawing.Size(65, 17);
            this.lblStationID.TabIndex = 0;
            this.lblStationID.Text = "StationID";
            // 
            // pnlSource
            // 
            this.pnlSource.Controls.Add(this.ddlSource);
            this.pnlSource.Controls.Add(this.lblSource);
            this.pnlSource.Location = new System.Drawing.Point(12, 237);
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Size = new System.Drawing.Size(234, 29);
            this.pnlSource.TabIndex = 2;
            // 
            // ddlSource
            // 
            this.ddlSource.FormattingEnabled = true;
            this.ddlSource.Location = new System.Drawing.Point(102, 3);
            this.ddlSource.Name = "ddlSource";
            this.ddlSource.Size = new System.Drawing.Size(121, 24);
            this.ddlSource.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(25, 4);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(53, 17);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // pnlTimeSpan
            // 
            this.pnlTimeSpan.Controls.Add(this.txtEndDate);
            this.pnlTimeSpan.Controls.Add(this.txtStartDate);
            this.pnlTimeSpan.Controls.Add(this.label9);
            this.pnlTimeSpan.Controls.Add(this.label8);
            this.pnlTimeSpan.Location = new System.Drawing.Point(252, 237);
            this.pnlTimeSpan.Name = "pnlTimeSpan";
            this.pnlTimeSpan.Size = new System.Drawing.Size(263, 66);
            this.pnlTimeSpan.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(81, 38);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(127, 22);
            this.txtEndDate.TabIndex = 3;
            this.txtEndDate.Text = "2015-01-31";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(81, 7);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(127, 22);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.Text = "2015-01-01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "End Date";
            // 
            // pnlDataFormat
            // 
            this.pnlDataFormat.Controls.Add(this.lblOutputDataFormat);
            this.pnlDataFormat.Controls.Add(this.ddlOutputDataFormat);
            this.pnlDataFormat.Location = new System.Drawing.Point(12, 308);
            this.pnlDataFormat.Name = "pnlDataFormat";
            this.pnlDataFormat.Size = new System.Drawing.Size(249, 37);
            this.pnlDataFormat.TabIndex = 10;
            // 
            // lblOutputDataFormat
            // 
            this.lblOutputDataFormat.AutoSize = true;
            this.lblOutputDataFormat.Location = new System.Drawing.Point(9, 9);
            this.lblOutputDataFormat.Name = "lblOutputDataFormat";
            this.lblOutputDataFormat.Size = new System.Drawing.Size(133, 17);
            this.lblOutputDataFormat.TabIndex = 0;
            this.lblOutputDataFormat.Text = "Output Data Format";
            // 
            // ddlOutputDataFormat
            // 
            this.ddlOutputDataFormat.FormattingEnabled = true;
            this.ddlOutputDataFormat.Location = new System.Drawing.Point(148, 6);
            this.ddlOutputDataFormat.Name = "ddlOutputDataFormat";
            this.ddlOutputDataFormat.Size = new System.Drawing.Size(83, 24);
            this.ddlOutputDataFormat.TabIndex = 1;
            // 
            // pnlTemporalResolution
            // 
            this.pnlTemporalResolution.Controls.Add(this.ddlTemporalResolution);
            this.pnlTemporalResolution.Controls.Add(this.lblTemporalResolution);
            this.pnlTemporalResolution.Location = new System.Drawing.Point(267, 308);
            this.pnlTemporalResolution.Name = "pnlTemporalResolution";
            this.pnlTemporalResolution.Size = new System.Drawing.Size(247, 37);
            this.pnlTemporalResolution.TabIndex = 11;
            // 
            // ddlTemporalResolution
            // 
            this.ddlTemporalResolution.FormattingEnabled = true;
            this.ddlTemporalResolution.Location = new System.Drawing.Point(150, 6);
            this.ddlTemporalResolution.Name = "ddlTemporalResolution";
            this.ddlTemporalResolution.Size = new System.Drawing.Size(85, 24);
            this.ddlTemporalResolution.TabIndex = 1;
            // 
            // lblTemporalResolution
            // 
            this.lblTemporalResolution.AutoSize = true;
            this.lblTemporalResolution.Location = new System.Drawing.Point(4, 9);
            this.lblTemporalResolution.Name = "lblTemporalResolution";
            this.lblTemporalResolution.Size = new System.Drawing.Size(139, 17);
            this.lblTemporalResolution.TabIndex = 0;
            this.lblTemporalResolution.Text = "Temporal Resolution";
            // 
            // pnlTimeZone
            // 
            this.pnlTimeZone.Controls.Add(this.ddlTimeZone);
            this.pnlTimeZone.Controls.Add(this.lblTimeZone);
            this.pnlTimeZone.Location = new System.Drawing.Point(12, 270);
            this.pnlTimeZone.Name = "pnlTimeZone";
            this.pnlTimeZone.Size = new System.Drawing.Size(234, 33);
            this.pnlTimeZone.TabIndex = 12;
            // 
            // ddlTimeZone
            // 
            this.ddlTimeZone.FormattingEnabled = true;
            this.ddlTimeZone.Location = new System.Drawing.Point(102, 4);
            this.ddlTimeZone.Name = "ddlTimeZone";
            this.ddlTimeZone.Size = new System.Drawing.Size(121, 24);
            this.ddlTimeZone.TabIndex = 1;
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(14, 9);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(76, 17);
            this.lblTimeZone.TabIndex = 0;
            this.lblTimeZone.Text = "Time Zone";
            // 
            // btnSubmitPrecip
            // 
            this.btnSubmitPrecip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitPrecip.Location = new System.Drawing.Point(217, 406);
            this.btnSubmitPrecip.Name = "btnSubmitPrecip";
            this.btnSubmitPrecip.Size = new System.Drawing.Size(84, 29);
            this.btnSubmitPrecip.TabIndex = 13;
            this.btnSubmitPrecip.Text = "Submit";
            this.btnSubmitPrecip.UseVisualStyleBackColor = false;
            this.btnSubmitPrecip.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlOutputs
            // 
            this.pnlOutputs.Controls.Add(this.txtOutputs);
            this.pnlOutputs.Location = new System.Drawing.Point(521, 31);
            this.pnlOutputs.Name = "pnlOutputs";
            this.pnlOutputs.Size = new System.Drawing.Size(667, 265);
            this.pnlOutputs.TabIndex = 14;
            // 
            // txtOutputs
            // 
            this.txtOutputs.Location = new System.Drawing.Point(0, 0);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.Size = new System.Drawing.Size(664, 261);
            this.txtOutputs.TabIndex = 0;
            this.txtOutputs.Text = "";
            // 
            // dgvOutputs
            // 
            this.dgvOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputs.Location = new System.Drawing.Point(527, 308);
            this.dgvOutputs.Name = "dgvOutputs";
            this.dgvOutputs.RowHeadersWidth = 51;
            this.dgvOutputs.RowTemplate.Height = 24;
            this.dgvOutputs.Size = new System.Drawing.Size(658, 260);
            this.dgvOutputs.TabIndex = 15;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(1021, 595);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(164, 36);
            this.btnSaveData.TabIndex = 16;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 17;
            // 
            // pnlAlgorithm
            // 
            this.pnlAlgorithm.Controls.Add(this.txtAlgorithm);
            this.pnlAlgorithm.Controls.Add(this.ddlAlgorithm);
            this.pnlAlgorithm.Location = new System.Drawing.Point(130, 112);
            this.pnlAlgorithm.Name = "pnlAlgorithm";
            this.pnlAlgorithm.Size = new System.Drawing.Size(234, 29);
            this.pnlAlgorithm.TabIndex = 19;
            // 
            // txtAlgorithm
            // 
            this.txtAlgorithm.AutoSize = true;
            this.txtAlgorithm.Location = new System.Drawing.Point(12, 6);
            this.txtAlgorithm.Name = "txtAlgorithm";
            this.txtAlgorithm.Size = new System.Drawing.Size(70, 17);
            this.txtAlgorithm.TabIndex = 1;
            this.txtAlgorithm.Text = "Algorithim";
            // 
            // ddlAlgorithm
            // 
            this.ddlAlgorithm.FormattingEnabled = true;
            this.ddlAlgorithm.Location = new System.Drawing.Point(110, 3);
            this.ddlAlgorithm.Name = "ddlAlgorithm";
            this.ddlAlgorithm.Size = new System.Drawing.Size(121, 24);
            this.ddlAlgorithm.TabIndex = 0;
            this.ddlAlgorithm.SelectedIndexChanged += new System.EventHandler(this.ddlAlgorithm_SelectedIndexChanged);
            // 
            // txtInputRequest
            // 
            this.txtInputRequest.Location = new System.Drawing.Point(15, 467);
            this.txtInputRequest.Name = "txtInputRequest";
            this.txtInputRequest.Size = new System.Drawing.Size(506, 164);
            this.txtInputRequest.TabIndex = 20;
            this.txtInputRequest.Text = "";
            // 
            // lblInputRequest
            // 
            this.lblInputRequest.AutoSize = true;
            this.lblInputRequest.Location = new System.Drawing.Point(214, 457);
            this.lblInputRequest.Name = "lblInputRequest";
            this.lblInputRequest.Size = new System.Drawing.Size(97, 17);
            this.lblInputRequest.TabIndex = 21;
            this.lblInputRequest.Text = "Request Body";
            // 
            // lblOutputText
            // 
            this.lblOutputText.AutoSize = true;
            this.lblOutputText.Location = new System.Drawing.Point(788, 20);
            this.lblOutputText.Name = "lblOutputText";
            this.lblOutputText.Size = new System.Drawing.Size(133, 17);
            this.lblOutputText.TabIndex = 22;
            this.lblOutputText.Text = "Unformatted Output";
            // 
            // lblOutputTable
            // 
            this.lblOutputTable.AutoSize = true;
            this.lblOutputTable.Location = new System.Drawing.Point(830, 299);
            this.lblOutputTable.Name = "lblOutputTable";
            this.lblOutputTable.Size = new System.Drawing.Size(91, 17);
            this.lblOutputTable.TabIndex = 23;
            this.lblOutputTable.Text = "Output Table";
            // 
            // pnlLayerDepth
            // 
            this.pnlLayerDepth.Controls.Add(this.lblLayerDepth);
            this.pnlLayerDepth.Controls.Add(this.ddlLayerDepth);
            this.pnlLayerDepth.Location = new System.Drawing.Point(15, 351);
            this.pnlLayerDepth.Name = "pnlLayerDepth";
            this.pnlLayerDepth.Size = new System.Drawing.Size(246, 40);
            this.pnlLayerDepth.TabIndex = 24;
            // 
            // lblLayerDepth
            // 
            this.lblLayerDepth.AutoSize = true;
            this.lblLayerDepth.Location = new System.Drawing.Point(4, 12);
            this.lblLayerDepth.Name = "lblLayerDepth";
            this.lblLayerDepth.Size = new System.Drawing.Size(118, 17);
            this.lblLayerDepth.TabIndex = 1;
            this.lblLayerDepth.Text = "Layer Depth (cm)";
            // 
            // ddlLayerDepth
            // 
            this.ddlLayerDepth.FormattingEnabled = true;
            this.ddlLayerDepth.Location = new System.Drawing.Point(123, 9);
            this.ddlLayerDepth.Name = "ddlLayerDepth";
            this.ddlLayerDepth.Size = new System.Drawing.Size(120, 24);
            this.ddlLayerDepth.TabIndex = 0;
            // 
            // pnlAlbedo
            // 
            this.pnlAlbedo.Controls.Add(this.txtAlbedo);
            this.pnlAlbedo.Controls.Add(this.lblAlbedo);
            this.pnlAlbedo.Location = new System.Drawing.Point(268, 351);
            this.pnlAlbedo.Name = "pnlAlbedo";
            this.pnlAlbedo.Size = new System.Drawing.Size(246, 40);
            this.pnlAlbedo.TabIndex = 26;
            // 
            // txtAlbedo
            // 
            this.txtAlbedo.Location = new System.Drawing.Point(134, 9);
            this.txtAlbedo.Name = "txtAlbedo";
            this.txtAlbedo.Size = new System.Drawing.Size(100, 22);
            this.txtAlbedo.TabIndex = 1;
            this.txtAlbedo.Text = "0.23";
            // 
            // lblAlbedo
            // 
            this.lblAlbedo.AutoSize = true;
            this.lblAlbedo.Location = new System.Drawing.Point(76, 12);
            this.lblAlbedo.Name = "lblAlbedo";
            this.lblAlbedo.Size = new System.Drawing.Size(52, 17);
            this.lblAlbedo.TabIndex = 0;
            this.lblAlbedo.Text = "Albedo";
            // 
            // btnSaveInputData
            // 
            this.btnSaveInputData.Location = new System.Drawing.Point(651, 595);
            this.btnSaveInputData.Name = "btnSaveInputData";
            this.btnSaveInputData.Size = new System.Drawing.Size(164, 36);
            this.btnSaveInputData.TabIndex = 27;
            this.btnSaveInputData.Text = "Save Input Data";
            this.btnSaveInputData.UseVisualStyleBackColor = true;
            this.btnSaveInputData.Click += new System.EventHandler(this.btnSaveInputData_Click);
            // 
            // btnSaveMetaData
            // 
            this.btnSaveMetaData.Location = new System.Drawing.Point(833, 595);
            this.btnSaveMetaData.Name = "btnSaveMetaData";
            this.btnSaveMetaData.Size = new System.Drawing.Size(164, 36);
            this.btnSaveMetaData.TabIndex = 28;
            this.btnSaveMetaData.Text = "Save Meta Data";
            this.btnSaveMetaData.UseVisualStyleBackColor = true;
            this.btnSaveMetaData.Click += new System.EventHandler(this.btnSaveMetaData_Click);
            // 
            // lnkWorkFlows
            // 
            this.lnkWorkFlows.AutoSize = true;
            this.lnkWorkFlows.Location = new System.Drawing.Point(185, 9);
            this.lnkWorkFlows.Name = "lnkWorkFlows";
            this.lnkWorkFlows.Size = new System.Drawing.Size(126, 17);
            this.lnkWorkFlows.TabIndex = 29;
            this.lnkWorkFlows.TabStop = true;
            this.lnkWorkFlows.Text = "Click for Workflows";
            this.lnkWorkFlows.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWorkFlows_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 643);
            this.Controls.Add(this.lnkWorkFlows);
            this.Controls.Add(this.btnSaveMetaData);
            this.Controls.Add(this.btnSaveInputData);
            this.Controls.Add(this.pnlAlbedo);
            this.Controls.Add(this.pnlLayerDepth);
            this.Controls.Add(this.lblOutputTable);
            this.Controls.Add(this.lblOutputText);
            this.Controls.Add(this.lblInputRequest);
            this.Controls.Add(this.txtInputRequest);
            this.Controls.Add(this.pnlAlgorithm);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.dgvOutputs);
            this.Controls.Add(this.pnlOutputs);
            this.Controls.Add(this.btnSubmitPrecip);
            this.Controls.Add(this.pnlTimeZone);
            this.Controls.Add(this.pnlDataFormat);
            this.Controls.Add(this.pnlTemporalResolution);
            this.Controls.Add(this.pnlTimeSpan);
            this.Controls.Add(this.pnlSource);
            this.Controls.Add(this.pnlStationID);
            this.Controls.Add(this.pnlCOMID);
            this.Controls.Add(this.lblAOI);
            this.Controls.Add(this.ddlAOI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlModules);
            this.Controls.Add(this.pnlLatLng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLatLng.ResumeLayout(false);
            this.pnlLatLng.PerformLayout();
            this.pnlCOMID.ResumeLayout(false);
            this.pnlCOMID.PerformLayout();
            this.pnlStationID.ResumeLayout(false);
            this.pnlStationID.PerformLayout();
            this.pnlSource.ResumeLayout(false);
            this.pnlSource.PerformLayout();
            this.pnlTimeSpan.ResumeLayout(false);
            this.pnlTimeSpan.PerformLayout();
            this.pnlDataFormat.ResumeLayout(false);
            this.pnlDataFormat.PerformLayout();
            this.pnlTemporalResolution.ResumeLayout(false);
            this.pnlTemporalResolution.PerformLayout();
            this.pnlTimeZone.ResumeLayout(false);
            this.pnlTimeZone.PerformLayout();
            this.pnlOutputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).EndInit();
            this.pnlAlgorithm.ResumeLayout(false);
            this.pnlAlgorithm.PerformLayout();
            this.pnlLayerDepth.ResumeLayout(false);
            this.pnlLayerDepth.PerformLayout();
            this.pnlAlbedo.ResumeLayout(false);
            this.pnlAlbedo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLatLng;
        private System.Windows.Forms.ComboBox ddlModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.ComboBox ddlAOI;
        private System.Windows.Forms.Label lblAOI;
        private System.Windows.Forms.Label lblCOMID;
        private System.Windows.Forms.TextBox txtCOMID;
        private System.Windows.Forms.Panel pnlCOMID;
        private System.Windows.Forms.Panel pnlStationID;
        private System.Windows.Forms.TextBox txtStationID;
        private System.Windows.Forms.Label lblStationID;
        private System.Windows.Forms.Panel pnlSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox ddlSource;
        private System.Windows.Forms.Panel pnlTimeSpan;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlDataFormat;
        private System.Windows.Forms.ComboBox ddlOutputDataFormat;
        private System.Windows.Forms.Label lblOutputDataFormat;
        private System.Windows.Forms.Panel pnlTemporalResolution;
        private System.Windows.Forms.ComboBox ddlTemporalResolution;
        private System.Windows.Forms.Label lblTemporalResolution;
        private System.Windows.Forms.Panel pnlTimeZone;
        private System.Windows.Forms.ComboBox ddlTimeZone;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Button btnSubmitPrecip;
        private System.Windows.Forms.Panel pnlOutputs;
        private System.Windows.Forms.DataGridView dgvOutputs;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox txtOutputs;
        private System.Windows.Forms.Panel pnlAlgorithm;
        private System.Windows.Forms.Label txtAlgorithm;
        private System.Windows.Forms.ComboBox ddlAlgorithm;
        private System.Windows.Forms.RichTextBox txtInputRequest;
        private System.Windows.Forms.Label lblInputRequest;
        private System.Windows.Forms.Label lblOutputText;
        private System.Windows.Forms.Label lblOutputTable;
        private System.Windows.Forms.Panel pnlLayerDepth;
        private System.Windows.Forms.Label lblLayerDepth;
        private System.Windows.Forms.ComboBox ddlLayerDepth;
        private System.Windows.Forms.Panel pnlAlbedo;
        private System.Windows.Forms.TextBox txtAlbedo;
        private System.Windows.Forms.Label lblAlbedo;
        private System.Windows.Forms.Button btnSaveInputData;
        private System.Windows.Forms.Button btnSaveMetaData;
        private System.Windows.Forms.LinkLabel lnkWorkFlows;
    }
}

