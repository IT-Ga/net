using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_CARD
{
    public class DAL_thecao : DBConnection
    {
        public DataTable getCARD()
        {
            SqlDataAdapter da= new SqlDataAdapter("select* from thecao", con);
            DataTable daDB = new DataTable();
            da.Fill(daDB);
            daDB.Columns.Add("STT");
            for (int i = 1; i <= daDB.Rows.Count; i++)
                daDB.Rows[i - 1]["STT"] = i.ToString();
            return daDB;
        }
        public bool searchthecao(string mathe)
        {
            string str = string.Format("select mathe from thecao", mathe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool insertthecao(string mathe, string tenthe, string maloai, string giatien, string soluong)
        {
            string str = string.Format("insert into thecao(mathe,tenthe,maloai,giatien,soluong) values('{0}','{1}','{2}','{3}',{4})", mathe, tenthe, maloai, giatien,soluong);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool updatethecao(string mathe, string tenthe, string maloai, string giatien, string soluong)
        {
            string str = string.Format("update thecao set tenthe='{0}', maloai='{1}', giatien='{2}', soluong='{3}' where mathe='{4}'", tenthe, maloai, giatien, soluong, mathe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public bool deletethecao(string mathe)
        {
            string str = string.Format("delete from thecao where mathe = '{0}'", mathe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
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
