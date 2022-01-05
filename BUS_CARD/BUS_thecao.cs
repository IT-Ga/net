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
    public class BUS_thecao
    {
        DAL_thecao daCA = new DAL_thecao();
        public DataTable getThe()
        {
            return daCA.getCARD();
        }

        public bool insertthecao(string mathe, string tenthe, string maloai, string giatien, string soluong)
        {
            return daCA.insertthecao(mathe,tenthe,maloai,giatien,soluong);
        }
        public bool updatethecao(string mathe, string tenthe, string maloai, string giatien, string soluong)
        {
            return daCA.updatethecao(mathe, tenthe, maloai, giatien, soluong);
        }
        public bool deletethecao(string mathe)
        {
            return daCA.deletethecao(mathe);
        }
        public bool searchthecao(string mathe)
        {
            return daCA.searchthecao(mathe);
        }

       
    }
}
