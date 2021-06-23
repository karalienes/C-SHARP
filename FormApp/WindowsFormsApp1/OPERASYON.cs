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
       
        public OPERASYON()
        {
            InitializeComponent();
        }
        


        void OperasyonShow()
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select *From Operasyon", db);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();

        }

        private void OPERASYON_Load(object sender, EventArgs e)
        {
            OperasyonShow();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text2.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text4.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text5.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            text6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "INSERT INTO OPERASYON(OperasyonKodu,ToplamOperasyonSüresi,İşlemSüresi,BeklemeSüresi,TaşımaSüresi,OperasyonAçıklaması) VALUES(@OperasyonKodu,@ToplamOperasyonSüresi,@İşlemSüresi,@BeklemeSüresi,@TaşımaSüresi,@OperasyonAçıklaması)";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@OperasyonKodu", text1.Text);
            komut.Parameters.AddWithValue("@ToplamOperasyonSüresi", text2.Text);
            komut.Parameters.AddWithValue("@İşlemSüresi", text3.Text);
            komut.Parameters.AddWithValue("@BeklemeSüresi", text4.Text);
            komut.Parameters.AddWithValue("@TaşımaSüresi", text5.Text);
            komut.Parameters.AddWithValue("@OperasyonAçıklaması", text6.Text);
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            OperasyonShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "DELETE FROM Operasyon WHERE OperasyonKodu=@OperasyonKodu";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@OperasyonKodu", Convert.ToInt32(text1.Text));
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            OperasyonShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "UPDATE Operasyon SET OperasyonKodu=@OperasyonKodu,ToplamOperasyonSüresi=@ToplamOperasyonSüresi,İşlemSüresi=@İşlemSüresi,BeklemeSüresi=@BeklemeSüresi,TaşımaSüresi=@TaşımaSüresi,OperasyonAçıklaması=@OperasyonAçıklaması WHERE OperasyonKodu=@OperasyonKodu";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@OperasyonKodu", Convert.ToInt32(text1.Text));
            komut.Parameters.AddWithValue("@ToplamOperasyonSüresi", text2.Text);
            komut.Parameters.AddWithValue("@İşlemSüresi", text3.Text);
            komut.Parameters.AddWithValue("@BeklemeSüresi", text4.Text);
            komut.Parameters.AddWithValue("@TaşımaSüresi", text5.Text);
            komut.Parameters.AddWithValue("@OperasyonAçıklaması", text6.Text);
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            OperasyonShow();
        }
    }
}
