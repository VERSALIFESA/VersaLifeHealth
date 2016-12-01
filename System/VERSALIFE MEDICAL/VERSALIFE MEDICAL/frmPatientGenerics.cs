using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    class frmPatientGenerics
    {
        static MySqlConnection connectionObject = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectToVersaDB"].ConnectionString);
        public static decimal retrieveNextID() {
            try
            {
                decimal nextID = 0;

                string selectNextID = "select ((MAX(pat_number))+1) from tbl_patient";
                MySqlCommand readNextIDcmd = new MySqlCommand(selectNextID, connectionObject);

                connectionObject.Open();
                nextID = Convert.ToDecimal(readNextIDcmd.ExecuteScalar());
                connectionObject.Close();

                return nextID;
            }
            catch {
                return 0;
            }
        }
    }
}
