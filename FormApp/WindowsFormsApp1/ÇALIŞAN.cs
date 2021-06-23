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
        
        
        public ÇALIŞAN()
        {
            InitializeComponent();
            
        }

        void ÇalısanShow()
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select *From Çalışan", db);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
            db.Close();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ÇalısanShow();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "INSERT INTO Çalışan(Tc,AdSoyad,Görev,BirimSaatMaliyet,AylıkMaliyet) VALUES(@Tc,@AdSoyad,@Görev,@BirimSaatMaliyet,@AylıkMaliyet)";
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@Tc", text1.Text);
            komut.Parameters.AddWithValue("@AdSoyad", text2.Text);
            komut.Parameters.AddWithValue("@Görev", text3.Text);
            komut.Parameters.AddWithValue("@BirimSaatMaliyet", text4.Text);
            komut.Parameters.AddWithValue("@AylıkMaliyet", text5.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            ÇalısanShow();
        }

        private void buttonSİL_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "DELETE FROM Çalışan WHERE Tc=@Tc";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@TC", Convert.ToInt32(text1.Text));
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            ÇalısanShow();
        }

        private void buttonGÜNCEL_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection("Data Source=DESKTOP-8RJHTU7\\MSSQLSERVER2;Initial Catalog=görselödev;Integrated Security=True");
            string sorgu = "UPDATE Çalışan SET Tc=@Tc,AdSoyad=@AdSoyad,Görev=@Görev,BirimSaatMaliyet=@BirimSaatMaliyet, AylıkMaliyet=@AylıkMaliyet  WHERE Tc=@Tc";
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.Parameters.AddWithValue("@Tc", Convert.ToInt32(text1.Text));
            komut.Parameters.AddWithValue("@AdSoyad", text2.Text);
            komut.Parameters.AddWithValue("@Görev", text3.Text);
            komut.Parameters.AddWithValue("@BirimSaatMaliyet", text4.Text);
            komut.Parameters.AddWithValue("@AylıkMaliyet", text5.Text);
            db.Open();
            komut.ExecuteNonQuery();
            db.Close();
            ÇalısanShow();

        }
    }
}
