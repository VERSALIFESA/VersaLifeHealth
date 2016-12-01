using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VERSALIFE_MEDICAL
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();                           //form closing
            frmLoginGenerics.checkConnectionState = true;
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

        private void frmPatient_Load(object sender, EventArgs e)
        {
            //Retrieve Next Patient ID
            decimal nextID = frmPatientGenerics.retrieveNextID();
            if (frmPatientGenerics.retrieveNextID() == 0)
            {
                MessageBox.Show("There was an error while retrieving the next available patient ID", "", MessageBoxButtons.RetryCancel);
            }
            else
            {
                txtPatNumber.Text = frmPatientGenerics.retrieveNextID().ToString();
            }
        }

        private void frmPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin loginFormInstance = new frmLogin();
            frmLoginGenerics.checkConnectionState = true; //Re-enable the drawing of the LED indicator
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

                MySqlConnection connectionObject = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectToVersaDB"].ConnectionString);
                string qryInsertDetails = "insert into tbl_patient values(@pat_ID, default, @pat_firstname, @pat_middlename, @pat_lastname, @pat_title, @pat_gender, @pat_DOB, @pat_age, @pat_race, @pat_tel, @pat_mobile, @pat_email, @pat_address, @pat_city, @pat_province, @pat_postalCode, @pat_date, @pat_notes, @pat_attachement)";
                MySqlCommand insertCmd = new MySqlCommand(qryInsertDetails, connectionObject);

            try
            {
                insertCmd.Parameters.Add("@pat_ID", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtID.Text);
                insertCmd.Parameters.Add("@pat_firstname", MySqlDbType.VarChar).Value = txtFirstName.Text;
                insertCmd.Parameters.Add("@pat_middlename", MySqlDbType.VarChar).Value = txtMiddleName.Text;
                insertCmd.Parameters.Add("@pat_lastname", MySqlDbType.VarChar).Value = txtLastName.Text;
                insertCmd.Parameters.Add("@pat_title", MySqlDbType.VarChar).Value = cmbTitle.SelectedItem;
                insertCmd.Parameters.Add("@pat_gender", MySqlDbType.VarChar).Value = cmbGender.SelectedItem;
                insertCmd.Parameters.Add("@pat_DOB", MySqlDbType.Date).Value = calenderDOB.Value;
                insertCmd.Parameters.Add("@pat_age", MySqlDbType.Int16).Value = Convert.ToInt16(txtAge.Text);
                insertCmd.Parameters.Add("@pat_race", MySqlDbType.VarChar).Value = cmbRace.SelectedItem;
                insertCmd.Parameters.Add("@pat_tel", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtTelephone.Text);
                insertCmd.Parameters.Add("@pat_mobile", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtMobile.Text);
                insertCmd.Parameters.Add("@pat_email", MySqlDbType.VarChar).Value = txtEmailAddress.Text;
                insertCmd.Parameters.Add("@pat_address", MySqlDbType.VarChar).Value = txtAddress.Text;
                insertCmd.Parameters.Add("@pat_city", MySqlDbType.VarChar).Value = txtCity.Text;
                insertCmd.Parameters.Add("@pat_province", MySqlDbType.VarChar).Value = txtProvince.Text;
                insertCmd.Parameters.Add("@pat_postalCode", MySqlDbType.Int16).Value = Convert.ToInt16(txtPostalCode.Text);
                insertCmd.Parameters.Add("@pat_date", MySqlDbType.DateTime).Value = calendarCaptureDate.Value;
                insertCmd.Parameters.Add("@pat_notes", MySqlDbType.VarChar).Value = txtNotes.Text;
                insertCmd.Parameters.Add("@pat_attachement", MySqlDbType.VarChar).Value = txtAttachments.Text;

                try
                {
                    connectionObject.Open();
                    try
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Failed to regsiter the patient", "Insertion Issue\nMore details: " + ex.Message, MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not connect to database", "Connection failed to open\nMore details: " + ex.Message, MessageBoxButtons.OK);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error while processing inserted values. Pleaase check values entered\nMore details: " + ex.Message ,"Incorrect Inputs at ",MessageBoxButtons.OK);
            }
            connectionObject.Close();
        }
    }
}
