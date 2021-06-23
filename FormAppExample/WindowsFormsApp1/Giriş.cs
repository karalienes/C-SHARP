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
    public partial class Giriş : Form
    {
        SqlConnection bağlantı;
        SqlCommand komut;
        SqlCommand komut2;
        SqlDataAdapter da; 
        SqlParameter prm1;
        SqlParameter prm2;

        public Giriş()
        {
            InitializeComponent();
        }
        public string datab = "Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bağlantı = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True");
                bağlantı.Open();
                string komut = "Select * From Login where ID=@ID AND ŞİFRE=@ŞİFRE";
                prm1 = new SqlParameter("ID", textBox1.Text.Trim());
                prm2 = new SqlParameter("ŞİFRE", textBox2.Text.Trim());
                komut2 = new SqlCommand(komut, bağlantı);
                komut2.Parameters.Add(prm1);
                komut2.Parameters.Add(prm2);
                DataTable table = new DataTable();
                da = new SqlDataAdapter(komut2);
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    ANASAYFA ana = new ANASAYFA();
                    ana.Show();
                    this.Hide();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("HATALI GİRİŞ...");
            }
        }
    }
}
