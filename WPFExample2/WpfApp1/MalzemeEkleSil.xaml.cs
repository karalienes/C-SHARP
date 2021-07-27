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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// MalzemeEkleSil.xaml etkileşim mantığı
    /// </summary>
    public partial class MalzemeEkleSil : Window
    {
        public MalzemeEkleSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "DELETE FROM malzemeler  WHERE MalzemeID=@MalzemeID";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = text1.Text;

            Veritabanı.komut1.ExecuteNonQuery();
            Veritabanı.con.Close();
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "UPDATE malzemeler SET MalzemeAdı=@MalzemeAdı,MalzemeTürü=@MalzemeTürü,MalzemeKonumu=@MalzemeKonumu,MalzemedenSorumluKişi=@MalzemedenSorumluKişi,MalzemeDurumu=@MalzemeDurumu,MalzemeTarih=@MalzemeTarih,MalzemeDiğer=@MalzemeDiğer WHERE MalzemeID=@MalzemeID";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = text2.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeAdı", SqlDbType.NVarChar).Value = text3.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeTürü", SqlDbType.NVarChar).Value = text4.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeKonumu", SqlDbType.NVarChar).Value = text5.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemedenSorumluKişi", SqlDbType.NVarChar).Value = text6.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeDurumu", SqlDbType.NVarChar).Value = text7.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeTarih", SqlDbType.NVarChar).Value = text8.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeDiğer", SqlDbType.NVarChar).Value = text9.Text;

            Veritabanı.komut1.ExecuteNonQuery();
            Veritabanı.con.Close();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "INSERT INTO malzemeler(MalzemeAdı,MalzemeTürü,MalzemeKonumu,MalzemedenSorumluKişi,MalzemeDurumu,MalzemeTarih,MalzemeDiğer) VALUES(@MalzemeAdı,@MalzemeTürü,@MalzemeKonumu,@MalzemedenSorumluKişi,@MalzemeDurumu,@MalzemeTarih,@MalzemeDiğer)";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@MalzemeID", SqlDbType.NVarChar).Value = text2.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeAdı", SqlDbType.NVarChar).Value = text10.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeTürü", SqlDbType.NVarChar).Value = text11.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeKonumu", SqlDbType.NVarChar).Value = text12.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemedenSorumluKişi", SqlDbType.NVarChar).Value = text13.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeDurumu", SqlDbType.NVarChar).Value = text14.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeTarih", SqlDbType.NVarChar).Value = text15.Text;
            Veritabanı.komut1.Parameters.Add("@MalzemeDiğer", SqlDbType.NVarChar).Value = text16.Text;

            Veritabanı.komut1.ExecuteNonQuery();
            Veritabanı.con.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            text10.Text = "";
            text11.Text = "";
            text12.Text = "";
            text13.Text = "";
            text14.Text = "";
            text15.Text = "";
            text16.Text = "";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MainWindow mainback = new MainWindow();
            mainback.Show();
            Hide();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Malzemeler malzemeback = new Malzemeler();
            malzemeback.Show();
            Hide();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MalzemeEkleSil malzemeekleback = new MalzemeEkleSil();
            malzemeekleback.Show();
            Hide();
        }
    }
}
