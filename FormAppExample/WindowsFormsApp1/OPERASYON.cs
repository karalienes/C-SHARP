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
    public partial class OPERASYON : Form
    {
        SqlConnection bağlantı;
        SqlCommand komut;
        SqlDataAdapter da;
        public OPERASYON()
        {
            InitializeComponent();
        }
        public string datab = "Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=deneme;Integrated Security=True";


        void OperasyonGetir()
        {
            bağlantı = new SqlConnection(datab);
            bağlantı.Open();
            da = new SqlDataAdapter("Select *From OPERASYON", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();

        }

        private void OPERASYON_Load(object sender, EventArgs e)
        {
            OperasyonGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textOpeSüre.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textİşlemSüre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBeklemeSüre.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textTaşımaSüre.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textAçıklama.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO OPERASYON(OperasyonKodu,ToplamOperasyonSüresi,İşlemSüresi,BeklemeSüresi,TaşımaSüresi,OperasyonAçıklaması) VALUES(@OperasyonKodu,@ToplamOperasyonSüresi,@İşlemSüresi,@BeklemeSüresi,@TaşımaSüresi,@OperasyonAçıklaması)";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@OperasyonKodu", textKod.Text);
            komut.Parameters.AddWithValue("@ToplamOperasyonSüresi", textOpeSüre.Text);
            komut.Parameters.AddWithValue("@İşlemSüresi", textİşlemSüre.Text);
            komut.Parameters.AddWithValue("@BeklemeSüresi", textBeklemeSüre.Text);
            komut.Parameters.AddWithValue("@TaşımaSüresi", textTaşımaSüre.Text);
            komut.Parameters.AddWithValue("@OperasyonAçıklaması", textAçıklama.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            OperasyonGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM OPERASYON WHERE OperasyonKodu=@OperasyonKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@OperasyonKodu", Convert.ToInt32(textKod.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            OperasyonGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE OPERASYON SET OperasyonKodu=@OperasyonKodu,ToplamOperasyonSüresi=@ToplamOperasyonSüresi,İşlemSüresi=@İşlemSüresi,BeklemeSüresi=@BeklemeSüresi,TaşımaSüresi=@TaşımaSüresi,OperasyonAçıklaması=@OperasyonAçıklaması WHERE OperasyonKodu=@OperasyonKodu";
            komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@OperasyonKodu", Convert.ToInt32(textKod.Text));
            komut.Parameters.AddWithValue("@ToplamOperasyonSüresi", textOpeSüre.Text);
            komut.Parameters.AddWithValue("@İşlemSüresi", textİşlemSüre.Text);
            komut.Parameters.AddWithValue("@BeklemeSüresi", textBeklemeSüre.Text);
            komut.Parameters.AddWithValue("@TaşımaSüresi", textTaşımaSüre.Text);
            komut.Parameters.AddWithValue("@OperasyonAçıklaması", textAçıklama.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            OperasyonGetir();
        }
    }
}
