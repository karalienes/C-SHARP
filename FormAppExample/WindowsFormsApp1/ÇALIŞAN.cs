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
    public partial class ÇALIŞAN : Form
    {
        SqlConnection bağlantı;
        SqlCommand komut;
        SqlDataAdapter da;
        public ÇALIŞAN()
        {
            InitializeComponent();
            
        }
        public string datab = "Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True";
        void MüşteriGetir()
        {
            bağlantı = new SqlConnection(datab);
            bağlantı.Open();
            da = new SqlDataAdapter("Select *From ÇALIŞAN1", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MüşteriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textGÖREV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBSMALİ.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textAYLIKMALİ.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ÇALIŞAN1(TC,ADSOYAD,GÖREV,BSMALİYETİ,AylıkMaliyeti) VALUES(@TC,@ADSOYAD,@GÖREV,@BSMALİYETİ,@AylıkMaliyeti)";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@TC", textID.Text);
            komut.Parameters.AddWithValue("@ADSOYAD", textAD.Text);
            komut.Parameters.AddWithValue("@GÖREV", textGÖREV.Text);
            komut.Parameters.AddWithValue("@BSMALİYETİ", textBSMALİ.Text);
            komut.Parameters.AddWithValue("@AylıkMaliyeti", textAYLIKMALİ.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            MüşteriGetir();
        }

        private void buttonSİL_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ÇALIŞAN1 WHERE TC=@TC";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@TC", Convert.ToInt32(textID.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            MüşteriGetir();
        }

        private void buttonGÜNCEL_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ÇALIŞAN1 SET TC=@TC,ADSOYAD=@ADSOYAD,GÖREV=@GÖREV,BSMALİYETİ=@BSMALİYETİ, AylıkMaliyeti=@AylıkMaliyeti  WHERE TC=@TC";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@TC", Convert.ToInt32(textID.Text));
            komut.Parameters.AddWithValue("@ADSOYAD", textAD.Text);
            komut.Parameters.AddWithValue("@GÖREV", textGÖREV.Text);
            komut.Parameters.AddWithValue("@BSMALİYETİ", textBSMALİ.Text);
            komut.Parameters.AddWithValue("@AylıkMaliyeti", textAYLIKMALİ.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            MüşteriGetir();

        }
    }
}
