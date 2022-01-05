using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_CARD
{
    public class DAL_USER : DBConnection
    {
        public bool getDB(string username, string password)
        {
            string st = string.Format("Select * from username where username = '{0}' and password = '{1}'", username, password);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {

                return false;
            }
            con.Close();
            return true;
        }
    }
}
