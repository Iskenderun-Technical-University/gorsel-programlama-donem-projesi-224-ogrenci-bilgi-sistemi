using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using OBS.islemler;

namespace OBS.islemler
{
    internal class girisKontrol
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;

        public static string sqlcon = @"Data Source=DESKTOP-K2C3H0A;Initial Catalog = Universite_Obs; Integrated Security = True";

        // akademisyen Girisi
        
        public static bool akademisyenGirisi(string kullaniciAdi,string sifre)
        {
            string sorgu = "select * from tbl_akademisyen where akdid=@user and akdSifre=@pass";

            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@pass", sifre);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
