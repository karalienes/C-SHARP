using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Ödev
{

    public partial class Form1 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand komut;
        OleDbConnection bağlantı;
        public Form1()
        {
            InitializeComponent();
        }

        public string datab = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/black/OneDrive/Masaüstü/Ödev/Ödev/bin/Debug/hasta_bilgisi.accdb");
        void Data_base()
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView11.DataSource = tablo;
            bağlantı.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Data_base();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            text0.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_hasta(hasta_id,isim,d_tarihi,d_yeri,kan_grubu,cinsiyet,adres,tel) VALUES(@hasta_id,@isim,@d_tarihi,@d_yeri,@kan_grubu,@cinsiyet,@adres,@tel)";
            komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@hasta_id", text0.Text);
            komut.Parameters.AddWithValue("@isim", text1.Text);
            komut.Parameters.AddWithValue("@d_tarihi", text2.Text);
            komut.Parameters.AddWithValue("@d_yeri", text3.Text);
            komut.Parameters.AddWithValue("@kan_grubu", text4.Text);
            komut.Parameters.AddWithValue("@cinsiyet", text5.Text);
            komut.Parameters.AddWithValue("@adres", text6.Text);
            komut.Parameters.AddWithValue("@tel", text7.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_hasta WHERE hasta_id=@hasta_id";
            komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@dhasta_id", Convert.ToInt32(text0.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE tbl_hasta SET isim=@isim,d_tarihi=@d_tarihi,d_yeri=@d_yeri,kan_grubu=@kan_grubu,cinsiyet=@cinsiyet,adres=@adres,tel=@tel  WHERE tel=@tel";
            komut = new OleDbCommand(sorgu, bağlantı);
            //komut.Parameters.AddWithValue("@hasta_id", text0.Text);
            komut.Parameters.AddWithValue("@isim", text1.Text);
            komut.Parameters.AddWithValue("@d_tarihi", text2.Text);
            komut.Parameters.AddWithValue("@d_yeri", text3.Text);
            komut.Parameters.AddWithValue("@kan_grubu", text4.Text);
            komut.Parameters.AddWithValue("@cinsiyet", text5.Text);
            komut.Parameters.AddWithValue("@adres", text6.Text);
            komut.Parameters.AddWithValue("@tel", text7.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text0.Text = "";
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
            text7.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 geçiş = new Form2();
            geçiş.Show();
            Hide();
        }

        private void A_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'a%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }

        private void BCD_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'b%' or isim like 'c%' or isim like 'd%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'e%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'f%' or isim like 'g%' or isim like 'h%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView4.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'ı%' or isim like 'i%'  ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView5.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'j%' or isim like 'k%' or isim like 'l%' or isim like 'm%' or isim like 'n%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView6.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'o%' or isim like 'ö%'  ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView7.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'p%' or isim like 'r%' or isim like 't%' or isim like 's%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView8.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'u%' or isim like 'ü%'  ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView9.DataSource = tablo;
            bağlantı.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta where isim like 'v%' or isim like 'y%' or isim like 'z%' or isim like 's%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView10.DataSource = tablo;
            bağlantı.Close();
        }

        private void dataGridView10_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView10.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView10.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView10.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView10.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView10.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView10.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView10.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView4.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView5.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView5.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView5.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView6_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView6.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView6.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView6.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView6.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView7_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView7.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView7.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView7.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView7.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView7.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView8_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView8.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView8.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView8.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView8.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView8.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView8.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView8.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView8.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView9_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView9.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView9.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView9.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView9.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView9.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView9.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView11_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text0.Text = dataGridView11.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView11.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView11.CurrentRow.Cells[2].Value.ToString();
            text3.Text = dataGridView11.CurrentRow.Cells[3].Value.ToString();
            text4.Text = dataGridView11.CurrentRow.Cells[4].Value.ToString();
            text5.Text = dataGridView11.CurrentRow.Cells[5].Value.ToString();
            text6.Text = dataGridView11.CurrentRow.Cells[6].Value.ToString();
            text7.Text = dataGridView11.CurrentRow.Cells[7].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_hasta ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }
    }
}
