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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
            frmLoginGenerics.drawStatusLED(Color.Orange);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLoginGenerics.drawStatusLED(Color.Orange);
            frmLoginGenerics.connectivityTest.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLoginGenerics.connectivityTest.Abort();
            Application.Exit();
        }


        public static string userID;
        public static string userPassword;
        private void btnSignin_Click(object sender, EventArgs e)
        {
            userID = txtUsername.Text;
            userPassword = txtPassword.Text;
            

            if (frmLoginGenerics.IsValid(userID))
            {
                if (frmLoginGenerics.verifyCredentials(userID, userPassword))
                {
                    frmMain dashBoard = new frmMain();
                    dashBoard.Show();
                }
            }    

        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                btnSignin.Enabled = false;
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
                btnSignin.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                btnSignin.Enabled = false;
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
                btnSignin.Enabled = true;
        }


    }

}
