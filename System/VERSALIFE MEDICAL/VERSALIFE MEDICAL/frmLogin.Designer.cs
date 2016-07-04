namespace VERSALIFE_MEDICAL
{
    partial class frmLogin
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
            try
            {
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignin = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.picStatusLed = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnstextBox1 = new System.Windows.Forms.TextBox();
            this.pnstextBox2 = new System.Windows.Forms.TextBox();
            this.pnstextBox3 = new System.Windows.Forms.TextBox();
            this.pnstextBox4 = new System.Windows.Forms.TextBox();
            this.pnstextBox5 = new System.Windows.Forms.TextBox();
            this.pnstextBox6 = new System.Windows.Forms.TextBox();
            this.pnslabel4 = new System.Windows.Forms.Label();
            this.pnslabel5 = new System.Windows.Forms.Label();
            this.pnslabel6 = new System.Windows.Forms.Label();
            this.pnslabel7 = new System.Windows.Forms.Label();
            this.pnslabel8 = new System.Windows.Forms.Label();
            this.pnslabel9 = new System.Windows.Forms.Label();
            this.pnsbuttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pnsbuttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.pnsbuttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.pnlDataAccessConfiguration = new System.Windows.Forms.Panel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusLed)).BeginInit();
            this.pnlDataAccessConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VERSALIFE_MEDICAL.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(117, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(176, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(114, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(114, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnSignin
            // 
            this.btnSignin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSignin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSignin.Enabled = false;
            this.btnSignin.Location = new System.Drawing.Point(117, 211);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(90, 23);
            this.btnSignin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "&Sign in";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(229, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picStatusLed
            // 
            this.picStatusLed.Image = global::VERSALIFE_MEDICAL.Properties.Resources.iconready;
            this.picStatusLed.Location = new System.Drawing.Point(3, 261);
            this.picStatusLed.Name = "picStatusLed";
            this.picStatusLed.Size = new System.Drawing.Size(16, 16);
            this.picStatusLed.TabIndex = 7;
            this.picStatusLed.TabStop = false;
            this.picStatusLed.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(263, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "© VERSALIFE HEALTH GROUP (PTY) LTD";
            // 
            // pnstextBox1
            // 
            this.pnstextBox1.Location = new System.Drawing.Point(85, 17);
            this.pnstextBox1.Name = "pnstextBox1";
            this.pnstextBox1.PasswordChar = '*';
            this.pnstextBox1.Size = new System.Drawing.Size(247, 20);
            this.pnstextBox1.TabIndex = 9;
            // 
            // pnstextBox2
            // 
            this.pnstextBox2.Location = new System.Drawing.Point(85, 44);
            this.pnstextBox2.Name = "pnstextBox2";
            this.pnstextBox2.PasswordChar = '*';
            this.pnstextBox2.Size = new System.Drawing.Size(143, 20);
            this.pnstextBox2.TabIndex = 10;
            // 
            // pnstextBox3
            // 
            this.pnstextBox3.Location = new System.Drawing.Point(85, 117);
            this.pnstextBox3.Name = "pnstextBox3";
            this.pnstextBox3.PasswordChar = '*';
            this.pnstextBox3.Size = new System.Drawing.Size(143, 20);
            this.pnstextBox3.TabIndex = 11;
            // 
            // pnstextBox4
            // 
            this.pnstextBox4.Location = new System.Drawing.Point(85, 143);
            this.pnstextBox4.Name = "pnstextBox4";
            this.pnstextBox4.PasswordChar = '*';
            this.pnstextBox4.Size = new System.Drawing.Size(143, 20);
            this.pnstextBox4.TabIndex = 12;
            // 
            // pnstextBox5
            // 
            this.pnstextBox5.Location = new System.Drawing.Point(85, 71);
            this.pnstextBox5.Name = "pnstextBox5";
            this.pnstextBox5.PasswordChar = '*';
            this.pnstextBox5.Size = new System.Drawing.Size(62, 20);
            this.pnstextBox5.TabIndex = 13;
            // 
            // pnstextBox6
            // 
            this.pnstextBox6.Location = new System.Drawing.Point(381, 17);
            this.pnstextBox6.Name = "pnstextBox6";
            this.pnstextBox6.PasswordChar = '*';
            this.pnstextBox6.Size = new System.Drawing.Size(37, 20);
            this.pnstextBox6.TabIndex = 14;
            // 
            // pnslabel4
            // 
            this.pnslabel4.AutoSize = true;
            this.pnslabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel4.Location = new System.Drawing.Point(1, 20);
            this.pnslabel4.Name = "pnslabel4";
            this.pnslabel4.Size = new System.Drawing.Size(78, 13);
            this.pnslabel4.TabIndex = 15;
            this.pnslabel4.Text = "Database URL";
            // 
            // pnslabel5
            // 
            this.pnslabel5.AutoSize = true;
            this.pnslabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel5.Location = new System.Drawing.Point(1, 47);
            this.pnslabel5.Name = "pnslabel5";
            this.pnslabel5.Size = new System.Drawing.Size(79, 13);
            this.pnslabel5.TabIndex = 16;
            this.pnslabel5.Text = "Relation(Table)";
            // 
            // pnslabel6
            // 
            this.pnslabel6.AutoSize = true;
            this.pnslabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel6.Location = new System.Drawing.Point(61, 120);
            this.pnslabel6.Name = "pnslabel6";
            this.pnslabel6.Size = new System.Drawing.Size(18, 13);
            this.pnslabel6.TabIndex = 17;
            this.pnslabel6.Text = "ID";
            // 
            // pnslabel7
            // 
            this.pnslabel7.AutoSize = true;
            this.pnslabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel7.Location = new System.Drawing.Point(24, 146);
            this.pnslabel7.Name = "pnslabel7";
            this.pnslabel7.Size = new System.Drawing.Size(53, 13);
            this.pnslabel7.TabIndex = 18;
            this.pnslabel7.Text = "Password";
            // 
            // pnslabel8
            // 
            this.pnslabel8.AutoSize = true;
            this.pnslabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel8.Location = new System.Drawing.Point(34, 74);
            this.pnslabel8.Name = "pnslabel8";
            this.pnslabel8.Size = new System.Drawing.Size(45, 13);
            this.pnslabel8.TabIndex = 19;
            this.pnslabel8.Text = "Timeout";
            // 
            // pnslabel9
            // 
            this.pnslabel9.AutoSize = true;
            this.pnslabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnslabel9.Location = new System.Drawing.Point(332, 20);
            this.pnslabel9.Name = "pnslabel9";
            this.pnslabel9.Size = new System.Drawing.Size(46, 13);
            this.pnslabel9.TabIndex = 20;
            this.pnslabel9.Text = "Port No.";
            // 
            // pnsbuttonX1
            // 
            this.pnsbuttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.pnsbuttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.pnsbuttonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pnsbuttonX1.Location = new System.Drawing.Point(164, 175);
            this.pnsbuttonX1.Name = "pnsbuttonX1";
            this.pnsbuttonX1.Size = new System.Drawing.Size(90, 23);
            this.pnsbuttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnsbuttonX1.TabIndex = 22;
            this.pnsbuttonX1.Text = "&Save";
            // 
            // pnsbuttonX2
            // 
            this.pnsbuttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.pnsbuttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.pnsbuttonX2.Enabled = false;
            this.pnsbuttonX2.Location = new System.Drawing.Point(52, 175);
            this.pnsbuttonX2.Name = "pnsbuttonX2";
            this.pnsbuttonX2.Size = new System.Drawing.Size(106, 23);
            this.pnsbuttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnsbuttonX2.TabIndex = 21;
            this.pnsbuttonX2.Text = "&Test Configuration";
            this.pnsbuttonX2.Click += new System.EventHandler(this.pnsbuttonX2_Click);
            // 
            // pnsbuttonX3
            // 
            this.pnsbuttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.pnsbuttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.pnsbuttonX3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pnsbuttonX3.Location = new System.Drawing.Point(260, 175);
            this.pnsbuttonX3.Name = "pnsbuttonX3";
            this.pnsbuttonX3.Size = new System.Drawing.Size(90, 23);
            this.pnsbuttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnsbuttonX3.TabIndex = 23;
            this.pnsbuttonX3.Text = "&Exit";
            // 
            // pnlDataAccessConfiguration
            // 
            this.pnlDataAccessConfiguration.Controls.Add(this.pnsbuttonX1);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnsbuttonX3);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox1);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox2);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnsbuttonX2);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox3);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel9);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox4);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel8);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox5);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel7);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnstextBox6);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel6);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel4);
            this.pnlDataAccessConfiguration.Controls.Add(this.pnslabel5);
            this.pnlDataAccessConfiguration.Location = new System.Drawing.Point(22, 12);
            this.pnlDataAccessConfiguration.Name = "pnlDataAccessConfiguration";
            this.pnlDataAccessConfiguration.Size = new System.Drawing.Size(426, 201);
            this.pnlDataAccessConfiguration.TabIndex = 24;
            this.pnlDataAccessConfiguration.Visible = false;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.AutoSize = true;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX4.Location = new System.Drawing.Point(117, 254);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(90, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 25;
            this.buttonX4.Text = "&Hide/Show";
            this.buttonX4.Visible = false;
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VERSALIFE_MEDICAL.Properties.Resources.tittlebar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.pnlDataAccessConfiguration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picStatusLed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 490);
            this.MinimumSize = new System.Drawing.Size(450, 280);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERSALIFE MEDICAL";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusLed)).EndInit();
            this.pnlDataAccessConfiguration.ResumeLayout(false);
            this.pnlDataAccessConfiguration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private System.Windows.Forms.PictureBox picStatusLed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private DevComponents.DotNetBar.ButtonX btnSignin;
        private System.Windows.Forms.TextBox pnstextBox1;
        private System.Windows.Forms.TextBox pnstextBox2;
        private System.Windows.Forms.TextBox pnstextBox3;
        private System.Windows.Forms.TextBox pnstextBox4;
        private System.Windows.Forms.TextBox pnstextBox5;
        private System.Windows.Forms.TextBox pnstextBox6;
        private System.Windows.Forms.Label pnslabel4;
        private System.Windows.Forms.Label pnslabel5;
        private System.Windows.Forms.Label pnslabel6;
        private System.Windows.Forms.Label pnslabel7;
        private System.Windows.Forms.Label pnslabel8;
        private System.Windows.Forms.Label pnslabel9;
        private DevComponents.DotNetBar.ButtonX pnsbuttonX1;
        private DevComponents.DotNetBar.ButtonX pnsbuttonX2;
        private DevComponents.DotNetBar.ButtonX pnsbuttonX3;
        private System.Windows.Forms.Panel pnlDataAccessConfiguration;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        public System.Windows.Forms.TextBox txtPassword;
    }
}

