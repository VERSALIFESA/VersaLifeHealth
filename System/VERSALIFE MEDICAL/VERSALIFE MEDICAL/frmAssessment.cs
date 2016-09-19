using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


using System.Data.SqlClient;
using System.Data.Sql;

namespace VERSALIFE_MEDICAL
{
    public partial class frmAssessment : Form
    {
        public frmAssessment()
        {
            InitializeComponent();
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            //string connectionString = "server=mint.versalife.co.za;port=3306;user id=dbsa;database=VersaMain;persistsecurityinfo=False";
            string conString = "Server=tcp:mint.versalife.co.za,3306;Database=VersaMain;User ID=dbsa;Password=pandora4808;Encrypt=True;TrustServerCertificate=False;";
            SqlConnection conObject = new SqlConnection(conString);

            //conObject.Open();
            //conObject.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmBoxAlcohol_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxAlcohol.Checked) {
                cmBoxAlcoholType.Enabled = true;
                cmBoxAlcoholFrequency.Enabled = true;
            }
            else {
                cmBoxAlcoholType.Enabled = false;
                cmBoxAlcoholFrequency.Enabled = false;
            }
        }

        private void cmBoxSmoke_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxSmoke.Checked)
            {
                cmBoxSmokeType.Enabled = true;
                txtSmokeFrequency.Enabled = true;
            }
            else
            {
                cmBoxSmokeType.Enabled = false;
                txtSmokeFrequency.Enabled = false;
            }
        }

        private void chkBoxBlood_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxBlood.Checked)
            {
                txtBloodNote.Enabled = true;
            }
            else
            {
                txtBloodNote.Enabled = false;
            }
        }

        private void chkBoxProtein_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxProtein.Checked)
            {
                txtProteinNote.Enabled = true;
            }
            else
            {
                txtProteinNote.Enabled = false;
            }
        }

        private void chkBoxSugar_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxSugar.Checked)
            {
                txtSugarNote.Enabled = true;
            }
            else
            {
                txtSugarNote.Enabled = false;
            }
        }
    }
}
