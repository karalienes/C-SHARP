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
    /// Müsteriler.xaml etkileşim mantığı
    /// </summary>
    public partial class Malzemeler : Window
    {
        public Malzemeler()
        {
            InitializeComponent();
        }
        private void DbShow(object sender, RoutedEventArgs e)
        {

            Veritabanı.VeritabanıAc();
            Veritabanı.sorgu1 = "Select *from Malzemeler";
            Veritabanı.komut1.CommandType = CommandType.Text;
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;

            Veritabanı.daAdapter1 = new SqlDataAdapter(Veritabanı.komut1);
            Veritabanı.tablo1 = new DataTable();
            Veritabanı.daAdapter1.Fill(Veritabanı.tablo1);

            dataGrid.ItemsSource = Veritabanı.tablo1.DefaultView;

            Veritabanı.con.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Veritabanı.VeritabanıAc();
            Veritabanı.sorgu1 = "Select *From malzemeler where MalzemeAdı like '%" + text.Text + "%' ";
            Veritabanı.komut1.CommandType = CommandType.Text;
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;

            Veritabanı.daAdapter1 = new SqlDataAdapter(Veritabanı.komut1);
            Veritabanı.tablo1 = new DataTable();
            Veritabanı.daAdapter1.Fill(Veritabanı.tablo1);

            dataGrid.ItemsSource = Veritabanı.tablo1.DefaultView;
            Veritabanı.con.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MainWindow mainback = new MainWindow();
            mainback.Show();
            Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            Malzemeler malzemeback = new Malzemeler();
            malzemeback.Show();
            Hide();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.con.Close();
            MalzemeEkleSil malzemeekleback = new MalzemeEkleSil();
            malzemeekleback.Show();
            Hide();
        }
    }
}
