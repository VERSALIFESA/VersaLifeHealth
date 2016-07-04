// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-511368
// Development Version: Beta Version 1.0
// Developed By:        VERSALIFE MEDICAL SYSTEMS (PTY)LTD
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
    public partial class frmMain : DevComponents.DotNetBar.Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLoginGenerics.checkConnectionState = false; //Disable the drawing of the LED indicator
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmLoginGenerics.checkConnectionState = false; //Re-enable the drawing of the LED indicator
            Application.Exit();
        }
    }
}
