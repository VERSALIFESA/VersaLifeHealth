namespace VERSALIFE_MEDICAL
{
    partial class frmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPatID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PatientDetails = new System.Windows.Forms.GroupBox();
            this.calenderDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPatNumber = new System.Windows.Forms.TextBox();
            this.ContactDetails = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.HomeAddress = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.txtAttachments = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.lblCaptureDate = new System.Windows.Forms.Label();
            this.calendarCaptureDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PatientDetails.SuspendLayout();
            this.ContactDetails.SuspendLayout();
            this.HomeAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VERSALIFE_MEDICAL.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1137, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(289, 50);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(65, 15);
            this.lblIDNumber.TabIndex = 17;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastName.Location = new System.Drawing.Point(14, 82);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstName.Location = new System.Drawing.Point(13, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAge.Location = new System.Drawing.Point(289, 113);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.Location = new System.Drawing.Point(570, 50);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDOB.Location = new System.Drawing.Point(289, 82);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(73, 15);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle.Location = new System.Drawing.Point(584, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 15);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Title";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(303, 46);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(81, 15);
            this.lblEmailAddress.TabIndex = 25;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(580, 46);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(47, 15);
            this.lblMobile.TabIndex = 26;
            this.lblMobile.Text = "Mobile ";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMiddleName.Location = new System.Drawing.Point(14, 113);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(79, 15);
            this.lblMiddleName.TabIndex = 27;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(365, 39);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 28;
            this.lblCity.Text = "City";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNotes.Location = new System.Drawing.Point(316, 535);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 15);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notes";
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAttachments.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAttachments.Location = new System.Drawing.Point(33, 535);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(75, 15);
            this.lblAttachments.TabIndex = 30;
            this.lblAttachments.Text = "Attachments";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTelephone.Location = new System.Drawing.Point(21, 44);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(62, 15);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProvince.Location = new System.Drawing.Point(576, 37);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(53, 15);
            this.lblProvince.TabIndex = 32;
            this.lblProvince.Text = "Province";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddress.Location = new System.Drawing.Point(51, 40);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPostalCode.Location = new System.Drawing.Point(559, 66);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(68, 15);
            this.lblPostalCode.TabIndex = 34;
            this.lblPostalCode.Text = "Postal code";
            // 
            // lblPatID
            // 
            this.lblPatID.AutoSize = true;
            this.lblPatID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPatID.Location = new System.Drawing.Point(617, 127);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(91, 15);
            this.lblPatID.TabIndex = 50;
            this.lblPatID.Text = "Patient Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::VERSALIFE_MEDICAL.Properties.Resources.sidefloral;
            this.pictureBox2.Location = new System.Drawing.Point(1019, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 644);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // PatientDetails
            // 
            this.PatientDetails.Controls.Add(this.calenderDOB);
            this.PatientDetails.Controls.Add(this.cmbRace);
            this.PatientDetails.Controls.Add(this.lblRace);
            this.PatientDetails.Controls.Add(this.cmbGender);
            this.PatientDetails.Controls.Add(this.cmbTitle);
            this.PatientDetails.Controls.Add(this.txtID);
            this.PatientDetails.Controls.Add(this.txtAge);
            this.PatientDetails.Controls.Add(this.txtMiddleName);
            this.PatientDetails.Controls.Add(this.txtLastName);
            this.PatientDetails.Controls.Add(this.txtFirstName);
            this.PatientDetails.Controls.Add(this.lblAge);
            this.PatientDetails.Controls.Add(this.lblDOB);
            this.PatientDetails.Controls.Add(this.lblMiddleName);
            this.PatientDetails.Controls.Add(this.lblLastName);
            this.PatientDetails.Controls.Add(this.lblIDNumber);
            this.PatientDetails.Controls.Add(this.lblFirstName);
            this.PatientDetails.Controls.Add(this.lblGender);
            this.PatientDetails.Controls.Add(this.lblTitle);
            this.PatientDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.PatientDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PatientDetails.Location = new System.Drawing.Point(35, 148);
            this.PatientDetails.Name = "PatientDetails";
            this.PatientDetails.Size = new System.Drawing.Size(831, 149);
            this.PatientDetails.TabIndex = 52;
            this.PatientDetails.TabStop = false;
            this.PatientDetails.Text = "Personal Details";
            // 
            // calenderDOB
            // 
            this.calenderDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderDOB.Location = new System.Drawing.Point(389, 77);
            this.calenderDOB.Name = "calenderDOB";
            this.calenderDOB.Size = new System.Drawing.Size(161, 23);
            this.calenderDOB.TabIndex = 64;
            // 
            // cmbRace
            // 
            this.cmbRace.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbRace.ForeColor = System.Drawing.Color.DimGray;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.ItemHeight = 13;
            this.cmbRace.Items.AddRange(new object[] {
            "Black",
            "White",
            "Indian",
            "Other"});
            this.cmbRace.Location = new System.Drawing.Point(633, 108);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(180, 21);
            this.cmbRace.TabIndex = 63;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRace.Location = new System.Drawing.Point(586, 113);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(32, 15);
            this.lblRace.TabIndex = 62;
            this.lblRace.Text = "Race";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbGender.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 13;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(633, 45);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(180, 21);
            this.cmbGender.TabIndex = 60;
            // 
            // cmbTitle
            // 
            this.cmbTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbTitle.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.ItemHeight = 13;
            this.cmbTitle.Items.AddRange(new object[] {
            "MR.",
            "MRS.",
            "MS.",
            "SIR."});
            this.cmbTitle.Location = new System.Drawing.Point(633, 77);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(180, 21);
            this.cmbTitle.TabIndex = 59;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtID.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.Location = new System.Drawing.Point(389, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 56;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAge.ForeColor = System.Drawing.Color.DimGray;
            this.txtAge.Location = new System.Drawing.Point(389, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(161, 22);
            this.txtAge.TabIndex = 55;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiddleName.Location = new System.Drawing.Point(120, 108);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(151, 21);
            this.txtMiddleName.TabIndex = 53;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(120, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 22);
            this.txtLastName.TabIndex = 52;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.Location = new System.Drawing.Point(120, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 22);
            this.txtFirstName.TabIndex = 51;
            // 
            // txtPatNumber
            // 
            this.txtPatNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPatNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPatNumber.Location = new System.Drawing.Point(715, 123);
            this.txtPatNumber.Name = "txtPatNumber";
            this.txtPatNumber.Size = new System.Drawing.Size(151, 22);
            this.txtPatNumber.TabIndex = 57;
            // 
            // ContactDetails
            // 
            this.ContactDetails.Controls.Add(this.txtTelephone);
            this.ContactDetails.Controls.Add(this.txtEmailAddress);
            this.ContactDetails.Controls.Add(this.txtMobile);
            this.ContactDetails.Controls.Add(this.lblTelephone);
            this.ContactDetails.Controls.Add(this.lblMobile);
            this.ContactDetails.Controls.Add(this.lblEmailAddress);
            this.ContactDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ContactDetails.Location = new System.Drawing.Point(35, 320);
            this.ContactDetails.Name = "ContactDetails";
            this.ContactDetails.Size = new System.Drawing.Size(831, 90);
            this.ContactDetails.TabIndex = 58;
            this.ContactDetails.TabStop = false;
            this.ContactDetails.Text = "Contact Details";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTelephone.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelephone.Location = new System.Drawing.Point(119, 40);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(151, 22);
            this.txtTelephone.TabIndex = 58;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtEmailAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmailAddress.Location = new System.Drawing.Point(388, 42);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(162, 22);
            this.txtEmailAddress.TabIndex = 57;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtMobile.ForeColor = System.Drawing.Color.DimGray;
            this.txtMobile.Location = new System.Drawing.Point(633, 42);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(180, 22);
            this.txtMobile.TabIndex = 56;
            // 
            // HomeAddress
            // 
            this.HomeAddress.Controls.Add(this.txtPostalCode);
            this.HomeAddress.Controls.Add(this.txtAddress);
            this.HomeAddress.Controls.Add(this.txtProvince);
            this.HomeAddress.Controls.Add(this.txtCity);
            this.HomeAddress.Controls.Add(this.lblPostalCode);
            this.HomeAddress.Controls.Add(this.lblAddress);
            this.HomeAddress.Controls.Add(this.lblCity);
            this.HomeAddress.Controls.Add(this.lblProvince);
            this.HomeAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HomeAddress.Location = new System.Drawing.Point(35, 436);
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Size = new System.Drawing.Size(831, 93);
            this.HomeAddress.TabIndex = 59;
            this.HomeAddress.TabStop = false;
            this.HomeAddress.Text = "Home Address";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPostalCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPostalCode.Location = new System.Drawing.Point(633, 62);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(64, 22);
            this.txtPostalCode.TabIndex = 59;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.Location = new System.Drawing.Point(119, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 22);
            this.txtAddress.TabIndex = 58;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtProvince.ForeColor = System.Drawing.Color.DimGray;
            this.txtProvince.Location = new System.Drawing.Point(633, 32);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(151, 22);
            this.txtProvince.TabIndex = 57;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtCity.ForeColor = System.Drawing.Color.DimGray;
            this.txtCity.Location = new System.Drawing.Point(399, 33);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 22);
            this.txtCity.TabIndex = 56;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(1029, 734);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(99, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 61;
            this.buttonX1.Text = "&Exit";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(914, 734);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 23);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 60;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAttachments
            // 
            this.txtAttachments.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAttachments.ForeColor = System.Drawing.Color.DimGray;
            this.txtAttachments.Location = new System.Drawing.Point(36, 558);
            this.txtAttachments.Multiline = true;
            this.txtAttachments.Name = "txtAttachments";
            this.txtAttachments.Size = new System.Drawing.Size(236, 93);
            this.txtAttachments.TabIndex = 62;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNotes.ForeColor = System.Drawing.Color.DimGray;
            this.txtNotes.Location = new System.Drawing.Point(319, 558);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(287, 93);
            this.txtNotes.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(36, 666);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 23);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 65;
            this.btnBrowse.Text = "&Browse>>";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblCaptureDate
            // 
            this.lblCaptureDate.AutoSize = true;
            this.lblCaptureDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCaptureDate.Location = new System.Drawing.Point(268, 127);
            this.lblCaptureDate.Name = "lblCaptureDate";
            this.lblCaptureDate.Size = new System.Drawing.Size(76, 15);
            this.lblCaptureDate.TabIndex = 66;
            this.lblCaptureDate.Text = "Capture Date";
            // 
            // calendarCaptureDate
            // 
            this.calendarCaptureDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarCaptureDate.Location = new System.Drawing.Point(368, 121);
            this.calendarCaptureDate.Name = "calendarCaptureDate";
            this.calendarCaptureDate.Size = new System.Drawing.Size(213, 23);
            this.calendarCaptureDate.TabIndex = 67;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VERSALIFE_MEDICAL.Properties.Resources.tittlebar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1171, 733);
            this.Controls.Add(this.calendarCaptureDate);
            this.Controls.Add(this.lblCaptureDate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAttachments);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.HomeAddress);
            this.Controls.Add(this.ContactDetails);
            this.Controls.Add(this.PatientDetails);
            this.Controls.Add(this.txtPatNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPatID);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPatient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatient_FormClosing);
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PatientDetails.ResumeLayout(false);
            this.PatientDetails.PerformLayout();
            this.ContactDetails.ResumeLayout(false);
            this.ContactDetails.PerformLayout();
            this.HomeAddress.ResumeLayout(false);
            this.HomeAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPatID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox PatientDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPatNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.GroupBox ContactDetails;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.GroupBox HomeAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private System.Windows.Forms.TextBox txtAttachments;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonX btnBrowse;
        private System.Windows.Forms.DateTimePicker calenderDOB;
        private System.Windows.Forms.Label lblCaptureDate;
        private System.Windows.Forms.DateTimePicker calendarCaptureDate;
    }
}