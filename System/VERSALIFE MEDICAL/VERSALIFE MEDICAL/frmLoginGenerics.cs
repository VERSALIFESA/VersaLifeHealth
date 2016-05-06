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

namespace VERSALIFE_MEDICAL
{
    public class frmLoginGenerics
    {

        #region Initiate Database Connecttion Test and update the status LED
        // Initiate Database Connecttion Test and update the status LED

        static string con = ConfigurationManager.ConnectionStrings["connectToVersalife"].ConnectionString;     // Create a connection variable object


        public static Thread connectivityTest = new Thread(() => {
            drawStatusLED(Color.Orange);
            SqlConnection connect = new SqlConnection(con);                 // Initiate database connection test 
            drawStatusLED(Color.Orange);                        
            while (true)
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
            catch {
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
                return true;
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
        public static bool verifyCredentials(string userID, string userPassword) {

            string querySelect = "select * from tbl_syslogin where (usr_id=@usr_id and usr_password=@usr_password)";
            SqlCommand cmd = new SqlCommand( querySelect, userConnection);

           cmd.Parameters.Add("usr_id", SqlDbType.VarChar).Value = userID;
           cmd.Parameters.Add("usr_password", SqlDbType.Int).Value = Convert.ToInt32(userPassword);

            userConnection.Open();

            SqlDataReader readLoginrecord = cmd.ExecuteReader();

            if (readLoginrecord.Read())
            {

                sysuser = readLoginrecord["usr_id"].ToString() + " " + readLoginrecord["usr_firstname"].ToString() + " " + readLoginrecord["usr_password"].ToString() + " " + readLoginrecord["usr_role"].ToString();
                readLoginrecord.Close();
                userConnection.Close();
                return true;

            }
            else {
                readLoginrecord.Close();
                userConnection.Close();
                return false;
            }

            
            
        }

        // End User Authentication Object
        #endregion

    }
}
