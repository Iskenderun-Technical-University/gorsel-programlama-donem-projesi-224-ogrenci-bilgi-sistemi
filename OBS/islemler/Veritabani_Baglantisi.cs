using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace OBS.islemler
{
    // veri tabanı bağlantısı gerçekleştirme 
    class Veritabani_Baglantisi
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataSet ds;

        public static string sqlCon = @"Data Source=DESKTOP-K2C3H0A;Initial Catalog = Universite_Obs; Integrated Security = True";

        // bağlantı kontrolü
        public static bool baglantiKontrol()
        {
            using (con = new SqlConnection(sqlCon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }

        // herhangi bir formda kullanilan datagridview'in class sayesinde dinamik olarak database'den veri cekmesini saglayan method

        public static DataGridView gridVeriAktarimi(DataGridView grid, string sqlSelectSorgu)
        {
            con = new SqlConnection(sqlCon);
            da =new  SqlDataAdapter(sqlSelectSorgu, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, sqlSelectSorgu);
            grid.DataSource = ds.Tables[sqlSelectSorgu];
            con.Close();
            return grid;
        }
    }
}
