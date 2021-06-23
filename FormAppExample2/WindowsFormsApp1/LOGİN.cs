using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class LOGİN : Form
    {
        public LOGİN()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=YedekParça;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                string komut = "Select * From Login where KullanıcıID=@KullanıcıID AND KullanıcıŞifre=@KullanıcıŞifre";
                SqlParameter prm1 = new SqlParameter("KullanıcıID", text1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("KullanıcıŞifre", text2.Text.Trim());
                SqlCommand komutGir = new SqlCommand(komut, db);
                komutGir.Parameters.Add(prm1);
                komutGir.Parameters.Add(prm2);
                DataTable table = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(komutGir);
                data.Fill(table);

                if (table.Rows.Count > 0)
                {
                    ANASAYFA ana = new ANASAYFA();
                    ana.Show();
                    this.Hide();
                }
            }
            
            catch(Exception)
            {
                MessageBox.Show("HATALI GİRİŞ...");
            }
        }
    }
}
