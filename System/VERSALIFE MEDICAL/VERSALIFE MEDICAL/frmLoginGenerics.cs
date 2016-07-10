// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-511368
// Development Version: Beta Version 1.0
// Developed By:        VERSALIFE HEALTH GROUP (PTY)LTD
// Contact:             Support@versalife.co.za
// Development Date:    April 2016



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

namespace VERSALIFE_MEDICAL
{
    public class frmLoginGenerics
    {

        #region Initiate Database Connection Test and update the status LED
        // Initiate Database Connection Test and update the status LED

        static string con = ConfigurationManager.ConnectionStrings["connectToVersalife"].ConnectionString;     // Create a connection variable object

        public static bool checkConnectionState = true;
        public static Thread connectivityTest = new Thread(() =>
        {

            drawStatusLED(Color.Orange);
            SqlConnection connect = new SqlConnection(con);                 // Initiate database connection test 
            drawStatusLED(Color.Orange);
            while (checkConnectionState)
            {
                drawStatusLED(Color.Orange);
                try
                {
                    drawStatusLED(Color.Orange);
                    connect.Open();
                    drawStatusLED(Color.Green);                             // Status LED Green if Database connection is True
                    connect.Close();
                }
                catch
                {
                    drawStatusLED(Color.Red);                               // Status LED Red if Database connection is False
                }
                Thread.Sleep(5000);                                         // Try Connect again after 5 Seconds
            }
            Thread.Sleep(0);
        });

        // Database Connection Test End Region
        #endregion



        #region Initiate the Status LED Indicator Object
        // Create the Status LED Indicator object

        public static void drawStatusLED(Color color)
        {
            try
            {
                Form.ActiveForm.CreateGraphics().DrawEllipse(new Pen(color, 4), new Rectangle(12, 262, 4, 4));
            }
            catch
            {
                //The Login Form is not the active OS window anymore
            }
        }

        // Status LED indicator Object End
        #endregion

        #region User Credentials Input Validation Object
        // Validate that the correct information is provided by the user

        public static bool IsValid(string userId)
        {
            try
            {
                if (!userId.Contains("@versalife") /*|| !userId.Contains(".com") */)            // Check if username contains "@versalife" 
                {
                    MessageBox.Show("Please check your credentials and re-enter", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);           // Show an error messagebox should the username be incorrect
                }
                else
                {
                    return true;
                }
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // End User Credentials Validation Object
        #endregion



        #region User Authentication from the Database
        // Authenticate the User from the database with the provided User Credentials

        public static string sysuser;               // system user variable object
        static SqlConnection userConnection = new SqlConnection(con);
        public static bool verifyCredentials(string userID, string userPassword)
        {

            string querySelect = "select * from tbl_syslogin where (usr_id=@usr_id and usr_password=@usr_password)";
            SqlCommand cmd = new SqlCommand(querySelect, userConnection);

            cmd.Parameters.Add("usr_id", SqlDbType.VarChar).Value = userID;
            try
            {
                cmd.Parameters.Add("usr_password", SqlDbType.Int).Value = Convert.ToInt32(userPassword);
            }
            catch
            {
                //handles type conversion error
            }

            try
            {
                userConnection.Open();

                SqlDataReader readLoginrecord = cmd.ExecuteReader();

                if (userConnection.State == ConnectionState.Open) {
                    if (readLoginrecord.Read())
                    {

                        sysuser = readLoginrecord["usr_id"].ToString() + " " + readLoginrecord["usr_firstname"].ToString() + " " + readLoginrecord["usr_password"].ToString() + " " + readLoginrecord["usr_role"].ToString();
                        readLoginrecord.Close();
                        userConnection.Close();
                        return true;

                    }
                    else
                    {
                        readLoginrecord.Close();
                        userConnection.Close();
                        MessageBox.Show("User and/or Password incorrect. Please try again", "Error credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                else {
                   MessageBox.Show("Unble to connect. Your connection seems slow today", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   return false;
                }

                
            }
            catch
            {
                MessageBox.Show("Connection to remote server failed", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        // End User Authentication Object
        #endregion

        #region Magic-Trick case

        //Method to read the password value
        public static bool readMagicTrick(TextBox txtPassword)
        {
            try
            {
                if (txtPassword.Text == "magic-trick")
                {
                    return true;
                }
                else { return false; }
            }
            catch
            {
                //return false if can't read password textbox anymore
                //or control is not available for reading anymore
                return false;
            }
        }

        //task to check that

        #endregion


        #region Application Connection String Settings
        public static Form frmSettings;

        //Settings Form Controls initialisation(part. 1)
        static System.Windows.Forms.TextBox txtDB_URL = new System.Windows.Forms.TextBox();
        static System.Windows.Forms.TextBox txtDB_Table = new System.Windows.Forms.TextBox();
        static System.Windows.Forms.TextBox txtDB_UserID = new System.Windows.Forms.TextBox();
        static System.Windows.Forms.TextBox txtDB_UserPassword = new System.Windows.Forms.TextBox();
        static System.Windows.Forms.TextBox txtConnectionTimeout = new System.Windows.Forms.TextBox();
        static System.Windows.Forms.TextBox txtPortNumber = new System.Windows.Forms.TextBox();
        static DevComponents.DotNetBar.ButtonX btnRestartApp = new DevComponents.DotNetBar.ButtonX();


         
        public static void displaySettings()
        {
            frmSettings = new Form();

            //We draw the setting form
            frmSettings.Size = new Size(450, 205);
            frmSettings.FormBorderStyle = FormBorderStyle.None;

            int frmWidth = Screen.PrimaryScreen.Bounds.Width;
            int frmHeight = Screen.PrimaryScreen.Bounds.Height;
            frmSettings.StartPosition = FormStartPosition.Manual;
            frmSettings.Left = (frmWidth / 2) - (frmSettings.Width / 2);
            frmSettings.Top = (frmHeight / 2) + (280 / 2) - 15;
            frmSettings.BackColor = System.Drawing.Color.White;


            //We add controls to the from by starting with the panel
            //that contains all the forms

            // 
            // pnlDataAccessConfiguration
            // 
            System.Windows.Forms.Panel pnlDataAccessConfiguration = new System.Windows.Forms.Panel();
            pnlDataAccessConfiguration.SuspendLayout();
            pnlDataAccessConfiguration.Location = new System.Drawing.Point(12, 2);
            pnlDataAccessConfiguration.Name = "pnlDataAccessConfiguration";
            pnlDataAccessConfiguration.Size = new System.Drawing.Size(426, 201);



            //Settings Form Controls initialisation(part. 1)
            System.Windows.Forms.Label pnslabel4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pnslabel5 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pnslabel6 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pnslabel7 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pnslabel8 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label pnslabel9 = new System.Windows.Forms.Label();
            //DevComponents.DotNetBar.ButtonX btnRestartApp = new DevComponents.DotNetBar.ButtonX(); //Taken outside here to make it avaiable for technician to restart the app
            DevComponents.DotNetBar.ButtonX btnTestNewConfig = new DevComponents.DotNetBar.ButtonX();
            DevComponents.DotNetBar.ButtonX btnCloseForm = new DevComponents.DotNetBar.ButtonX();

            // 
            // txtDB_URL
            // 
            txtDB_URL.Location = new System.Drawing.Point(85, 17);
            txtDB_URL.Name = "txtDB_URL";
            txtDB_URL.Size = new System.Drawing.Size(247, 20);
            txtDB_URL.TabIndex = 0;
            // 
            // txtDB_Table
            // 
            txtDB_Table.Location = new System.Drawing.Point(85, 44);
            txtDB_Table.Name = "txtDB_Table";
            txtDB_Table.Size = new System.Drawing.Size(143, 20);
            txtDB_Table.TabIndex = 2;
            // 
            // txtDB_UserID
            // 
            txtDB_UserID.Location = new System.Drawing.Point(85, 117);
            txtDB_UserID.Name = "txtDB_UserID";
            txtDB_UserID.Size = new System.Drawing.Size(143, 20);
            txtDB_UserID.TabIndex = 4;
            // 
            // txtDB_UserPassword
            // 
            txtDB_UserPassword.Location = new System.Drawing.Point(85, 143);
            txtDB_UserPassword.Name = "txtDB_UserPassword";
            txtDB_UserPassword.PasswordChar = '*';
            txtDB_UserPassword.Size = new System.Drawing.Size(143, 20);
            txtDB_UserPassword.TabIndex = 5;
            // 
            // txtConnectionTimeout
            // 
            txtConnectionTimeout.Location = new System.Drawing.Point(85, 71);
            txtConnectionTimeout.Name = "txtConnectionTimeout";
            txtConnectionTimeout.Size = new System.Drawing.Size(62, 20);
            txtConnectionTimeout.TabIndex = 3;
            // 
            // txtPortNumber
            // 
            txtPortNumber.Location = new System.Drawing.Point(381, 17);
            txtPortNumber.Name = "txtPortNumber";
            txtPortNumber.Size = new System.Drawing.Size(37, 20);
            txtPortNumber.TabIndex = 1;
            // 
            // pnslabel4
            // 
            pnslabel4.AutoSize = true;
            pnslabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel4.Location = new System.Drawing.Point(1, 20);
            pnslabel4.Name = "pnslabel4";
            pnslabel4.Size = new System.Drawing.Size(78, 13);
            pnslabel4.TabIndex = 15;
            pnslabel4.Text = "Database URL";
            // 
            // pnslabel5
            // 
            pnslabel5.AutoSize = true;
            pnslabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel5.Location = new System.Drawing.Point(1, 47);
            pnslabel5.Name = "pnslabel5";
            pnslabel5.Size = new System.Drawing.Size(79, 13);
            pnslabel5.TabIndex = 16;
            pnslabel5.Text = "DB Name";
            // 
            // pnslabel6
            // 
            pnslabel6.AutoSize = true;
            pnslabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel6.Location = new System.Drawing.Point(61, 120);
            pnslabel6.Name = "pnslabel6";
            pnslabel6.Size = new System.Drawing.Size(18, 13);
            pnslabel6.TabIndex = 17;
            pnslabel6.Text = "ID";
            // 
            // pnslabel7
            // 
            pnslabel7.AutoSize = true;
            pnslabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel7.Location = new System.Drawing.Point(24, 146);
            pnslabel7.Name = "pnslabel7";
            pnslabel7.Size = new System.Drawing.Size(53, 13);
            pnslabel7.TabIndex = 18;
            pnslabel7.Text = "Password";
            // 
            // pnslabel8
            // 
            pnslabel8.AutoSize = true;
            pnslabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel8.Location = new System.Drawing.Point(34, 74);
            pnslabel8.Name = "pnslabel8";
            pnslabel8.Size = new System.Drawing.Size(45, 13);
            pnslabel8.TabIndex = 19;
            pnslabel8.Text = "Timeout";
            // 
            // pnslabel9
            // 
            pnslabel9.AutoSize = true;
            pnslabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            pnslabel9.Location = new System.Drawing.Point(332, 20);
            pnslabel9.Name = "pnslabel9";
            pnslabel9.Size = new System.Drawing.Size(46, 13);
            pnslabel9.TabIndex = 20;
            pnslabel9.Text = "Port No.";
            // 
            // btnRestartApp
            // 
            btnRestartApp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            btnRestartApp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnRestartApp.Enabled = false;
            btnRestartApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnRestartApp.Location = new System.Drawing.Point(164, 175);
            btnRestartApp.Name = "btnRestartApp";
            btnRestartApp.Size = new System.Drawing.Size(90, 23);
            btnRestartApp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnRestartApp.TabIndex = 8;
            btnRestartApp.Text = "&Restart";
            btnRestartApp.Click += new System.EventHandler(btnRestartApp_Click);
            // 
            // btnTestNewConfig
            // 
            btnTestNewConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            btnTestNewConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnTestNewConfig.Enabled = true;
            btnTestNewConfig.Location = new System.Drawing.Point(52, 175);
            btnTestNewConfig.Name = "btnTestNewConfig";
            btnTestNewConfig.Size = new System.Drawing.Size(106, 23);
            btnTestNewConfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnTestNewConfig.TabIndex = 6;
            btnTestNewConfig.Text = "&Test Configuration";
            btnTestNewConfig.Click += new System.EventHandler(btnTestNewConfig_Click);
            // 
            // btnCloseForm
            // 
            btnCloseForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            btnCloseForm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCloseForm.Location = new System.Drawing.Point(260, 175);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new System.Drawing.Size(90, 23);
            btnCloseForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            btnCloseForm.TabIndex = 7;
            btnCloseForm.Text = "&Exit";
            btnCloseForm.Click += new System.EventHandler(btnCloseForm_Click);

            //we add controls to the panel
            pnlDataAccessConfiguration.Controls.Add(btnRestartApp);
            pnlDataAccessConfiguration.Controls.Add(btnCloseForm);
            pnlDataAccessConfiguration.Controls.Add(txtDB_URL);
            pnlDataAccessConfiguration.Controls.Add(txtDB_Table);
            pnlDataAccessConfiguration.Controls.Add(btnTestNewConfig);
            pnlDataAccessConfiguration.Controls.Add(txtDB_UserID);
            pnlDataAccessConfiguration.Controls.Add(pnslabel9);
            pnlDataAccessConfiguration.Controls.Add(txtDB_UserPassword);
            pnlDataAccessConfiguration.Controls.Add(pnslabel8);
            pnlDataAccessConfiguration.Controls.Add(txtConnectionTimeout);
            pnlDataAccessConfiguration.Controls.Add(pnslabel7);
            pnlDataAccessConfiguration.Controls.Add(txtPortNumber);
            pnlDataAccessConfiguration.Controls.Add(pnslabel6);
            pnlDataAccessConfiguration.Controls.Add(pnslabel4);
            pnlDataAccessConfiguration.Controls.Add(pnslabel5);

            //we add the panel to the form
            frmSettings.Controls.Add(pnlDataAccessConfiguration);

            //Form tweeking
            frmSettings.CancelButton = btnCloseForm;

            //Display the form
            frmSettings.Show();
        }

        //
        private static void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult quitForm = MessageBox.Show("Are you sure you want to exit? Once exited, reaching this form is only available by restarting the aplicatioin", "Warning", MessageBoxButtons.YesNo);
            if (quitForm == DialogResult.Yes) {
                frmSettings.Close();
            }
        }

        public static void btnTestNewConfig_Click(object sender, EventArgs e) {
            //We check for technician inputs validity
            int timeOutValue;
            int portNumber;

            if (txtDB_URL.Text != "" && txtDB_Table.Text != "" && txtDB_UserID.Text != "" && txtDB_UserPassword.Text != "" && txtConnectionTimeout.Text != "" && txtPortNumber.Text != "") { //if all field are filled
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$");
                if (!r.IsMatch(txtDB_URL.Text))
                {
                    MessageBox.Show("Invalid database URL, please verify and or correct then try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txtConnectionTimeout.Text, out timeOutValue))
                {
                    MessageBox.Show("Connection Timeout valeue is invalid ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txtPortNumber.Text, out portNumber))
                {
                    MessageBox.Show("Port Number invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {//Everything is okay, we test the connection.
                    string newConnectionString = "Server=" + txtDB_URL.Text + "," + portNumber + ";Database= " + txtDB_Table.Text + ";User ID=" + txtDB_UserID.Text + ";Password=" + txtDB_UserPassword.Text + ";Encrypt=True;TrustServerCertificate=False;Connection Timeout=" + timeOutValue;

                    SqlConnection test_newConnectionString =  new SqlConnection(newConnectionString);
                    try {
                        test_newConnectionString.Open();
                        DialogResult msgBoxResult = MessageBox.Show("The test was successful. Do you wish to save these new settings", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (msgBoxResult == DialogResult.Yes) { //System saves the new configuartions
                            updateAppSettings("connectToVersalife", newConnectionString);

                            btnRestartApp.Enabled = true;
                            MessageBox.Show("You will need to restart the application in order to apply new settings. You can do so by cliking the \"Restart\" button", "Restart Required", MessageBoxButtons.OK);
                            
                            
                        }
                    }
                    catch{//Saving faild
                        MessageBox.Show("Unable to test new settings.\nSuggestions : \n1. Make sure you have internet acces\n2. Verify the values entered are corrected", "Error Connection", MessageBoxButtons.OK);
                    }
                }
            }
            else {
                MessageBox.Show("Please fill in every text field before testing", "Missing Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thi method restarts the application
        public static void btnRestartApp_Click(object sender, EventArgs e)
        {
            try
            {
                //run the program again and close this one
                Process.Start(Application.ExecutablePath);
                

                //close this one
                Process.GetCurrentProcess().Kill();
            }
            catch
            { }
        }


        public static void updateAppSettings(string key, string value)
        {
            try
            {
                //CreateXDocument and load configuration file
                XDocument doc = XDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                //Find all connection strings
                var query1 = from p in doc.Descendants("connectionStrings").Descendants()
                             select p;

                //Go throught each connection string elements find atribute specified by argument and replace its value with newVAlue
                foreach (var child in query1)
                {
                    foreach (var atr in child.Attributes())
                    {
                        if (atr.Name.LocalName == "name" && atr.Value == key)
                            if (atr.NextAttribute != null && atr.NextAttribute.Name == "connectionString")
                                atr.NextAttribute.Value = value;
                    }
                }

                doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Writing configuration", MessageBoxButtons.OK);    
            }
        }

        #endregion

    }
}
