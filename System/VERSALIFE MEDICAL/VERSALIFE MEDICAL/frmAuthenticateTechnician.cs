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
    public partial class frmAuthenticateTechnician : Form
    {
        public frmAuthenticateTechnician()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAuthenticateTechnician_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.Manual;
            frmAuthenticateTechnician.ActiveForm.AutoSize = true; 
            panel1.Visible = false;
            label4.Visible = false;
        }
       
        private void btnSignin_Click(object sender, EventArgs e)
        {
            frmAuthenticateTechnician.ActiveForm.AutoSize = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Visible = false;
            label4.Visible = true;

            string value1 = btnSignin.Text;
            switch (value1)
            {
                case "Expand":
                    panel1.Visible = true;
                    break;
                case "Reduce":
                    panel1.Visible = false;
                    break;
            }
            btnSignin.Text = "Reduce";
            if (panel1.Visible == true)
            {
                btnSignin.Text = "Reduce";
            }
            else if (panel1.Visible == false)
            {
                btnSignin.Text = "Expand";
            }
        }
    }
}
