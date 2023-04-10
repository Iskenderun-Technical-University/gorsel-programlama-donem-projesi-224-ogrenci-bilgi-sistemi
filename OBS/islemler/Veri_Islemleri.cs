using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OBS.islemler
{
    internal class Veri_Islemleri
    {
        static SqlConnection con;
        static SqlCommand cmd;
        public static void veriAktarma(string sql,SqlCommand cmd)
        {
            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            con.Open();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
