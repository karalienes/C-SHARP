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
    public partial class İŞİSTASYONU : Form
    {
        SqlConnection bağlantı;
        SqlCommand komut;
        SqlDataAdapter da;
        public İŞİSTASYONU()
        {
            InitializeComponent();
        }

        public string datab = "Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True";
        void İstasyonGetir()
        {
            bağlantı = new SqlConnection(datab);
            bağlantı.Open();
            da = new SqlDataAdapter("Select *From İŞİSTASYONU", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();

        }

        private void İŞİSTASYONU_Load(object sender, EventArgs e)
        {
            İstasyonGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textKodu.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAçıklama.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textAmbarı.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textMaliyeti.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO İŞİSTASYONU(İşİstasyonuKodu,İstasyonAçıklama,HammaddeAmbarı,İStasyonMaliyeti) VALUES(@İşİstasyonuKodu,@İstasyonAçıklama,@HammaddeAmbarı,@İStasyonMaliyeti)";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@İşİstasyonuKodu", textKodu.Text);
            komut.Parameters.AddWithValue("@İstasyonAçıklama", textAçıklama.Text);
            komut.Parameters.AddWithValue("@HammaddeAmbarı", textAmbarı.Text);
            komut.Parameters.AddWithValue("@İStasyonMaliyeti", textMaliyeti.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            İstasyonGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM İŞİSTASYONU WHERE İşİstasyonuKodu=@İşİstasyonuKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@İşİstasyonuKodu", Convert.ToInt32(textKodu.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            İstasyonGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE İŞİSTASYONU SET İşİstasyonuKodu=@İşİstasyonuKodu,İstasyonAçıklama=@İstasyonAçıklama,HammaddeAmbarı=@HammaddeAmbarı,İStasyonMaliyeti=@İStasyonMaliyeti  WHERE İşİstasyonuKodu=@İşİstasyonuKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@İşİstasyonuKodu", Convert.ToInt32(textKodu.Text));
            komut.Parameters.AddWithValue("@İstasyonAçıklama", textAçıklama.Text);
            komut.Parameters.AddWithValue("@HammaddeAmbarı", textAmbarı.Text);
            komut.Parameters.AddWithValue("@İStasyonMaliyeti", textMaliyeti.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            İstasyonGetir();

        }
    }
}
