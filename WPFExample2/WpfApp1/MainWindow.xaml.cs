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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WpfApp1;
namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DbShow(object sender, RoutedEventArgs e)
        {
            
            Veritabanı.VeritabanıAc();
            Veritabanı.sorgu1 = "Select *from Kullanıcılar";
            Veritabanı.komut1.CommandType = CommandType.Text;
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;

            Veritabanı.daAdapter1 = new SqlDataAdapter(Veritabanı.komut1);
            Veritabanı.tablo1 = new DataTable();
            Veritabanı.daAdapter1.Fill(Veritabanı.tablo1);

            dataGrid.ItemsSource = Veritabanı.tablo1.DefaultView;
            
            
            Veritabanı.sorgu2 = "Select KullanıcıAdı from Kullanıcılar";
            Veritabanı.komut2.CommandType = CommandType.Text;
            Veritabanı.komut2.CommandText = Veritabanı.sorgu2;

            Veritabanı.daAdapter2 = new SqlDataAdapter(Veritabanı.komut2);
            Veritabanı.tablo2 = new DataTable();
            Veritabanı.daAdapter2.Fill(Veritabanı.tablo2);

            dataGrid1.ItemsSource = Veritabanı.tablo2.DefaultView;


        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "INSERT INTO kullanıcılar(KullanıcıAdı,Sifre,Seviye) VALUES(@KullanıcıAdı,@Sifre,@Seviye)";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = text5.Text;
            Veritabanı.komut1.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = text6.Text;
            Veritabanı.komut1.Parameters.Add("@Seviye", SqlDbType.NVarChar).Value = text7.Text;


            Veritabanı.komut1.ExecuteNonQuery();
            Veritabanı.con.Close();
            DbShow(sender, e);
            Veritabanı.con.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "DELETE FROM kullanıcılar  WHERE KullanıcıAdı=@KullanıcıAdı";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = text8.Text;

            Veritabanı.komut1.ExecuteNonQuery();
            
           
            Veritabanı.con.Close();
            DbShow(sender, e);
            Veritabanı.con.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Veritabanı.con.Open();
            Veritabanı.sorgu1 = "UPDATE Kullanıcılar SET KullanıcıAdı=@KullanıcıAdı,Sifre=@Sifre,AdSoyad=@AdSoyad,Telefon=@Telefon,Eposta=@Eposta,Seviye=@Seviye WHERE KullanıcıID=@KullanıcıID";
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
            Veritabanı.komut1.CommandType = CommandType.Text;

            Veritabanı.komut1.Parameters.Clear();
            Veritabanı.komut1.Parameters.Add("@KullanıcıID", SqlDbType.NVarChar).Value = text15.Text;
            Veritabanı.komut1.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = text9.Text;
            Veritabanı.komut1.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = text10.Text;
            Veritabanı.komut1.Parameters.Add("@AdSoyad", SqlDbType.NVarChar).Value = text11.Text;
            Veritabanı.komut1.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = text12.Text;
            Veritabanı.komut1.Parameters.Add("@Eposta", SqlDbType.NVarChar).Value = text13.Text;
            Veritabanı.komut1.Parameters.Add("@Seviye", SqlDbType.NVarChar).Value = text14.Text;

            Veritabanı.komut1.ExecuteNonQuery();
            Veritabanı.con.Close();
            DbShow(sender, e);
            Veritabanı.con.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MainWindow mainback = new MainWindow();
            mainback.Show();
            Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Malzemeler malzemeback = new Malzemeler();
            malzemeback.Show();
            Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MalzemeEkleSil malzemeekleback = new MalzemeEkleSil();
            malzemeekleback.Show();
            Hide();
        }
    }
}
