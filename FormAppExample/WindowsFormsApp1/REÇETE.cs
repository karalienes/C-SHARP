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
    public partial class REÇETE : Form
    {
        SqlConnection bağlantı;
        SqlCommand komut;
        SqlDataAdapter da;
        public REÇETE()
        {
            InitializeComponent();
        }
        public string datab = "Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True";

        void ReçeteGetir()
        {
            bağlantı = new SqlConnection(datab);
            bağlantı.Open();
            da = new SqlDataAdapter("Select *From REÇETE", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();

        }

        private void REÇETE_Load(object sender, EventArgs e)
        {
            ReçeteGetir();
        }
       

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textAnaÜrün.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAçıklama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textMiktar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textSatırS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO REÇETE(AnaÜrünKodu,Açıklama,Miktar,SatırSayısı) VALUES(@AnaÜrünKodu,@Açıklama,@Miktar,@SatırSayısı)";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", textAnaÜrün.Text);
            komut.Parameters.AddWithValue("@Açıklama", textAçıklama.Text);
            komut.Parameters.AddWithValue("@Miktar", textMiktar.Text);
            komut.Parameters.AddWithValue("@SatırSayısı", textSatırS.Text);
            
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            ReçeteGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM REÇETE WHERE AnaÜrünKodu=@AnaÜrünKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", Convert.ToInt32(textAnaÜrün.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            ReçeteGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE REÇETE SET AnaÜrünKodu=@AnaÜrünKodu,Açıklama=@Açıklama,Miktar=@Miktar,SatırSayısı=@SatırSayısı WHERE AnaÜrünKodu=@AnaÜrünKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", Convert.ToInt32(textAnaÜrün.Text));
            komut.Parameters.AddWithValue("@Açıklama", textAçıklama.Text);
            komut.Parameters.AddWithValue("@Miktar", textMiktar.Text);
            komut.Parameters.AddWithValue("@SatırSayısı", textSatırS.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            ReçeteGetir();
        }
    }
}
