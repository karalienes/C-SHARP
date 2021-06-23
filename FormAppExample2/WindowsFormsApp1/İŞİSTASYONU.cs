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
        
        public İŞİSTASYONU()
        {
            InitializeComponent();
        }

        
        void İstasyonShow()
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=YedekParça;Integrated Security=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select *From YedekParça", db);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();

        }

        private void İŞİSTASYONU_Load(object sender, EventArgs e)
        {
            İstasyonShow();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text2.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text3.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=YedekParça;Integrated Security=True");
            string sorgu = "INSERT INTO YedekParça(Stok,RafKonum,Fiyat) VALUES(@Stok,@RafKonum,@Fiyat)";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@Stok", text1.Text);
            komut.Parameters.AddWithValue("@RafKonum", text2.Text);
            komut.Parameters.AddWithValue("@Fiyat", text3.Text);
            
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            İstasyonShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=YedekParça;Integrated Security=True");
            string sorgu = "DELETE FROM YedekParça WHERE RafKonum=@RafKonum";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@RafKonum", Convert.ToInt32(text1.Text));
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            İstasyonShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "UPDATE YedekParça SET Stok=@Stok,RafKonum=@RafKonum,Fiyat=@Fiyat  WHERE RafKonum=@RafKonum";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@Stok", Convert.ToInt32(text1.Text));
            komut.Parameters.AddWithValue("@RafKonum", text2.Text);
            komut.Parameters.AddWithValue("@Fiyat", text3.Text);
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            İstasyonShow();

        }
    }
}
