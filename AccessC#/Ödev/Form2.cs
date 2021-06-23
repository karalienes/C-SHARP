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
    public partial class Form2 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand komut;
        OleDbConnection bağlantı;
        public Form2()
        {
            InitializeComponent();
        }
        public string datab = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/black/OneDrive/Masaüstü/Ödev/Ödev/bin/Debug/hasta_bilgisi.accdb");
        void Data_base()
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_randevu ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }
        void Data_base1()
        {
            bağlantı = new OleDbConnection(datab);
            bağlantı.Open();
            da = new OleDbDataAdapter("Select *From tbl_randevu where randevu_hasta_id like '%" + text1.Text + "%' ", bağlantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Data_base();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 geçiş = new Form1();
            geçiş.Show();
            Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sorgu = "Select *From tbl_randevu where randevu_hasta_id like '%" + text1.Text +"%' ";
            komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@randevu_id", textBox1.Text);
            komut.Parameters.AddWithValue("@randevu_hasta_id", text1.Text);
            komut.Parameters.AddWithValue("@randevu_tarihi", text2.Text);
            komut.Parameters.AddWithValue("@teşhiş", text3.Text);
            komut.Parameters.AddWithValue("@tedavi", text4.Text);
            komut.Parameters.AddWithValue("@verilen_ilaç_id", text5.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
           Data_base1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_randevu(randevu_id,randevu_hasta_id,teşhis,tedavi,randevu_tarihi,verilen_ilaç_id) VALUES(@randevu_id,@randevu_hasta_id,@teşhis,@tedavi,@randevu_tarihi,@verilen_ilaç_id)";
            komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@randevu_id", textBox1.Text);
            komut.Parameters.AddWithValue("@randevu_hasta_id", text1.Text);
            komut.Parameters.AddWithValue("@randevu_tarihi", text2.Text);
            komut.Parameters.AddWithValue("@teşhis", text3.Text);
            komut.Parameters.AddWithValue("@tedavi", text4.Text);
            komut.Parameters.AddWithValue("@verilen_ilaç_id", text5.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_randevu WHERE randevu_id=@randevu_id";
            komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@randevu_id", Convert.ToInt32(textBox1.Text));
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tbl_randevu SET randevu_hasta_id=@randevu_hasta_id,teşhis=@teşhis,tedavi=@tedavi,randevu_tarihi=@randevu_tarihi,verilen_ilaç_id=@verilen_ilaç_id  WHERE randevu_tarihi=@randevu_tarihi";
            komut = new OleDbCommand(sorgu, bağlantı);
            //komut.Parameters.AddWithValue("@randevu_id", textBox1.Text);
            komut.Parameters.AddWithValue("@randevu_hasta_id", text1.Text);
            komut.Parameters.AddWithValue("@randevu_tarihi", text2.Text);
            komut.Parameters.AddWithValue("@teşhis", text3.Text);
            komut.Parameters.AddWithValue("@tedavi", text4.Text);
            komut.Parameters.AddWithValue("@verilen_ilaç_id", text5.Text);
            bağlantı.Open();
            komut.ExecuteNonQuery();
            bağlantı.Close();
            Data_base();
        }
    }
}
