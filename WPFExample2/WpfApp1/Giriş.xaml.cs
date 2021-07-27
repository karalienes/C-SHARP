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
    /// Giriş.xaml etkileşim mantığı
    /// </summary>
    public partial class Giriş : Window
    {
        public static SqlParameter para1, para2;
        public Giriş()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Veritabanı.VeritabanıAc();
            Veritabanı.sorgu1 = "Select KullanıcıAdı,Sifre From kullanıcılar where KullanıcıAdı=@KullanıcıAdı AND Sifre=@Sifre";
            Veritabanı.komut1.CommandType = CommandType.Text;
            Veritabanı.komut1.CommandText = Veritabanı.sorgu1;
           
           
            para1 = new SqlParameter("KullanıcıAdı", textBox.Text.Trim());
            para2 = new SqlParameter("Sifre", textBox1.Text.Trim());
            Veritabanı.komut2 = new SqlCommand(Veritabanı.sorgu1, Veritabanı.con);
            Veritabanı.komut2.Parameters.Add(para1);
            Veritabanı.komut2.Parameters.Add(para2);

            Veritabanı.daAdapter1 = new SqlDataAdapter(Veritabanı.komut2);
            Veritabanı.tablo1 = new DataTable();
            Veritabanı.daAdapter1.Fill(Veritabanı.tablo1);

            if (Veritabanı.tablo1.Rows.Count > 0)
            {
                Veritabanı.con.Close();
                MainWindow mainback = new MainWindow();
                mainback.Show();
                this.Hide();
            }
            Veritabanı.con.Close();
        }
    }
}
