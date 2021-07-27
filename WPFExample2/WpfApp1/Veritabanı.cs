using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class Veritabanı
    {
        public static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Veritabanı"].ToString();
            return connectionString;
        }
        
        public static string sorgu1,sorgu2;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand komut1 = new SqlCommand("", con);
        public static SqlCommand komut2 = new SqlCommand("", con);
        public static SqlDataReader daReader1,daReader2;
        public static DataTable tablo1,tablo2;
        public static SqlDataAdapter daAdapter1,daAdapter2;
        
       public static void VeritabanıAc()
        {
            con.ConnectionString = GetConnectionString();
            con.Open();
        }

    }
}
