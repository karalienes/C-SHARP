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
       
        public REÇETE()
        {
            InitializeComponent();
        }
       

        void Reçeteler()
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select *From Reçete", db);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();

        }

        private void REÇETE_Load(object sender, EventArgs e)
        {
            Reçeteler();
        }
       

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "INSERT INTO Reçete(AnaÜrünKodu,Açıklama,Miktar,SatırSayısı) VALUES(@AnaÜrünKodu,@Açıklama,@Miktar,@SatırSayısı)";
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", text1.Text);
            komut.Parameters.AddWithValue("@Açıklama", text2.Text);
            komut.Parameters.AddWithValue("@Miktar", text3.Text);
            komut.Parameters.AddWithValue("@SatırSayısı", text4.Text);
            
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Reçeteler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "DELETE FROM Reçete WHERE AnaÜrünKodu=@AnaÜrünKodu";
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", Convert.ToInt32(text1.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Reçeteler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "UPDATE Reçete SET AnaÜrünKodu=@AnaÜrünKodu,Açıklama=@Açıklama,Miktar=@Miktar,SatırSayısı=@SatırSayısı WHERE AnaÜrünKodu=@AnaÜrünKodu";
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@AnaÜrünKodu", Convert.ToInt32(text1.Text));
            komut.Parameters.AddWithValue("@Açıklama", text2.Text);
            komut.Parameters.AddWithValue("@Miktar", text3.Text);
            komut.Parameters.AddWithValue("@SatırSayısı", text4.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Reçeteler();
        }
    }
}
