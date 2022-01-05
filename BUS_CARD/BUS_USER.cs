using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_CARD;


namespace BUS_CARD
{
    public class BUS_USER
    {
        DAL_USER daUSer = new DAL_USER();
        public bool getLogin(string username, string password)
        {
            return daUSer.getDB(username, password);
        }
    }
    
}

