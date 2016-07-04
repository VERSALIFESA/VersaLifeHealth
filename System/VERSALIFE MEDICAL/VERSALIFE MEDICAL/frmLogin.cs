// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-411368
// Development Version: Beta Version 1.0
// Developed By:        VERSALIFE HEALTH GROUP (PTY)LTD
// Contact:             Support@versalife.co.za
// Development Date:    April 2016


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()

        #region initialize connection status LED indicator
        // Region used to initialize status LED indicator to indicate Database Connection Status
        {
            InitializeComponent();
            frmLoginGenerics.drawStatusLED(Color.Orange);
        }

        public static bool read_txtPassword = true; //enable reading of txtpassword for the magic-trick use-case
        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLoginGenerics.drawStatusLED(Color.Orange);
            frmLoginGenerics.connectivityTest.IsBackground = true;
            frmLoginGenerics.connectivityTest.Start();

            Task t = Task.Run(() =>
            {
                while (read_txtPassword)
                {
                    if (frmLoginGenerics.readMagicTrick(txtPassword))
                    {
                        frmLoginGenerics.displaySettings();
                        Application.Run();
                    }
                }
            });
        }

        // End of status LED indicator region
        #endregion


        #region Application Exit
        // Exit and Close the Application


        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLoginGenerics.connectivityTest.Abort();       // Terminate the frmLoginGenerics object
            Application.Exit();                              // Application Exit
        }

        // End of Application Exit Region
        #endregion

        #region System User Authentication
        // Region to accept user credentials and authenticate details to grant access

        public static string userID;
        public static string userPassword;
        private void btnSignin_Click(object sender, EventArgs e)
        {
            // variables declaration
            userID = txtUsername.Text;
            userPassword = txtPassword.Text;

            // User Authentication
            if (frmLoginGenerics.IsValid(userID))
            {
                if (frmLoginGenerics.verifyCredentials(userID, userPassword))
                {
                    frmMain dashBoard = new frmMain();                  // initiate the Dashbaord upon successfull user authentification
                    dashBoard.Show();
                    this.Hide();                                        // hide the current login form.
                }
            }   

        }

        // End of User authentication Region
        #endregion


        #region User input validatiion
        // Validate that the correct information and format is provided


        private void txtUsername_TextChanged(object sender, EventArgs e)            // Validate the Username Object
        {
            if (txtUsername.Text == "")
            {
                btnSignin.Enabled = false;
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
                btnSignin.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)            // Validate the Password Object
        {
            if (txtPassword.Text == "")
            {
                btnSignin.Enabled = false;
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
                btnSignin.Enabled = true;
        }


        // User Input Validation End
        #endregion


        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (pnlDataAccessConfiguration.Visible == false)
            {
                this.AutoSize = true;
                pnlDataAccessConfiguration.Visible = true;
            }
            else {
                pnlDataAccessConfiguration.Visible = false;
                this.AutoSize = false;
            }
        }

        private void pnsbuttonX2_Click(object sender, EventArgs e)
        {

        }
    }

}
