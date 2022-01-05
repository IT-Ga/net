using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_CARD
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-12J6D6C\\SQLEXPRESS;uid=sa;pwd=123;database=card");
    }
}
