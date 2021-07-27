using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GÖRSEL1;

namespace GÖRSEL1
{
    /// <summary>
    /// malzeme2.xaml etkileşim mantığı
    /// </summary>
    public partial class malzeme2 : Window
    {
        public malzeme2()
        {
            InitializeComponent();
        }

        

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainn = new MainWindow();
            mainn.Show();
            Hide();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            malzeme malzeme1 = new malzeme();
            malzeme1.Show();
            Hide();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            malzeme2 malzeme22 = new malzeme2();
            malzeme22.Show();
            Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Db.sql = "DELETE FROM malzemeler  WHERE MalzemeID=@MalzemeID";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = textBox14.Text;



            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Db.sql = "INSERT INTO malzemeler(MalzemeAdı,MalzemeTürü,MalzemeKonumu,MalzemedenSorumluKişi,MalzemeDurumu,MalzemeTarih,MalzemeDiğer) VALUES(@MalzemeAdı,@MalzemeTürü,@MalzemeKonumu,@MalzemedenSorumluKişi,@MalzemeDurumu,@MalzemeTarih,@MalzemeDiğer)";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = textBox15.Text;
            Db.cmd.Parameters.Add("@MalzemeAdı", SqlDbType.NVarChar).Value = textBox13.Text;
            Db.cmd.Parameters.Add("@MalzemeTürü", SqlDbType.NVarChar).Value = textBox12.Text;
            Db.cmd.Parameters.Add("@MalzemeKonumu", SqlDbType.NVarChar).Value = textBox11.Text;
            Db.cmd.Parameters.Add("@MalzemedenSorumluKişi", SqlDbType.NVarChar).Value = textBox10.Text;
            Db.cmd.Parameters.Add("@MalzemeDurumu", SqlDbType.NVarChar).Value = textBox.Text;
            Db.cmd.Parameters.Add("@MalzemeTarih", SqlDbType.NVarChar).Value = textBox9.Text;
            Db.cmd.Parameters.Add("@MalzemeDiğer", SqlDbType.NVarChar).Value = textBox8.Text;


            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Db.sql = "UPDATE malzemeler SET MalzemeAdı=@MalzemeAdı,MalzemeTürü=@MalzemeTürü,MalzemeKonumu=@MalzemeKonumu,MalzemedenSorumluKişi=@MalzemedenSorumluKişi,MalzemeDurumu=@MalzemeDurumu,MalzemeTarih=@MalzemeTarih,MalzemeDiğer=@MalzemeDiğer WHERE MalzemeID=@MalzemeID";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = textBox15.Text;
            Db.cmd.Parameters.Add("@MalzemeAdı", SqlDbType.NVarChar).Value = textBox7.Text;
            Db.cmd.Parameters.Add("@MalzemeTürü", SqlDbType.NVarChar).Value = textBox6.Text;
            Db.cmd.Parameters.Add("@MalzemeKonumu", SqlDbType.NVarChar).Value = textBox5.Text;
            Db.cmd.Parameters.Add("@MalzemedenSorumluKişi", SqlDbType.NVarChar).Value = textBox4.Text;
            Db.cmd.Parameters.Add("@MalzemeDurumu", SqlDbType.NVarChar).Value = textBox3.Text;
            Db.cmd.Parameters.Add("@MalzemeTarih", SqlDbType.NVarChar).Value = textBox2.Text;
            Db.cmd.Parameters.Add("@MalzemeDiğer", SqlDbType.NVarChar).Value = textBox1.Text;

            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.textBox13.Text = "";
            this.textBox12.Text = "";
            this.textBox11.Text = "";
            this.textBox10.Text = "";
            this.textBox.Text = "";
            this.textBox9.Text = "";
            this.textBox8.Text = "";
        }
    }
}
