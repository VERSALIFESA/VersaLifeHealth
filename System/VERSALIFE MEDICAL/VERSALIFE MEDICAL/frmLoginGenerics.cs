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
        /**********************************************************************/
        /*** What follows is the thread fucntion controlling the Status LED ***/
        /*******              BALUKIDI NEHEMIE @ VERSALIFE              *******/
        /*******              Friday 14 of April 2016                   *******/
        /**********************************************************************/



        #region Initiate System Connection Test
        // Initiate Database Connecttion Test and update the status LED

        static string con = ConfigurationManager.ConnectionStrings["connectToVersalife"].ConnectionString;


        public static Thread connectivityTest = new Thread(() => {
            drawStatusLED(Color.Orange);
            SqlConnection connect = new SqlConnection(con);
            drawStatusLED(Color.Orange);
            while (true)
            {
                drawStatusLED(Color.Orange);
                try
                {
                    drawStatusLED(Color.Orange);
                    connect.Open();
                    drawStatusLED(Color.LawnGreen);
                    connect.Close();
                }
                catch
                {
                    drawStatusLED(Color.Red);
                }
                Thread.Sleep(5000);
            }
        });

        public static void drawStatusLED(Color color)
        {
            try
            {
                Form.ActiveForm.CreateGraphics().DrawEllipse(new Pen(color, 4), new Rectangle(4, 262, 4, 4));
            }
            catch {
                //The Login Form is not the active OS window anymore
            }
        }

        /**********************************************************************/
        /**********************************************************************/


        public static bool IsValid(string userId)
        {
            try
            {
                if (!userId.Contains("@versalife") /*|| !userId.Contains(".com") */)
                {
                    MessageBox.Show("Please check your credentials and re-enter", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static string theThing;
        static SqlConnection userConnection = new SqlConnection(con);
        public static bool verifyCredentials(string userID, string userPassword)
        {

            string querySelect = "select * from tbl_syslogin where (usr_id=@usr_id and usr_password=@usr_password)";
            SqlCommand cmd = new SqlCommand(querySelect, userConnection);

            cmd.Parameters.Add("usr_id", SqlDbType.VarChar).Value = userID;
            cmd.Parameters.Add("usr_password", SqlDbType.Int).Value = Convert.ToInt32(userPassword);

            userConnection.Open();

            SqlDataReader readLoginrecord = cmd.ExecuteReader();

            if (readLoginrecord.Read())
            {

                theThing = readLoginrecord["usr_id"].ToString() + " " + readLoginrecord["usr_firstname"].ToString() + " " + readLoginrecord["usr_password"].ToString() + " " + readLoginrecord["usr_role"].ToString();
                readLoginrecord.Close();
                userConnection.Close();
                return true;

            }
            else
            {
                readLoginrecord.Close();
                userConnection.Close();
                return false;
            }

        }

    } 


