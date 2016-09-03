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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();                              // Application Exit
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFileDialog = new OpenFileDialog();

            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAttachments.Text = browseFileDialog.FileName;  
                           
            }

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAttachments_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.Location = new Point(0, 0);
            Size formSize = new Size(Screen.GetWorkingArea(this).Width, Screen.GetWorkingArea(this).Height);
            Size formSize1 = new Size(Screen.GetWorkingArea(this).Right, Screen.GetWorkingArea(this).Left);
            this.Size = new Size(formSize.Width, formSize.Height);
        }
    }
}
