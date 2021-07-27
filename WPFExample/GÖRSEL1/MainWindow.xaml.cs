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
using GÖRSEL1;

namespace GÖRSEL1
{

    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    class Db
    {
        public static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            return connectionString;
        }

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string sql2;
        
        public static SqlCommand cmd2 = new SqlCommand("", con);
        public static SqlDataReader rd2;
        public static DataTable dt2;
        public static SqlDataAdapter da2;


        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = GetConnectionString();
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB kapalıdır.");

            }
        }

        public static void closeConnetion()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Db aciktir.");
            }
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender,RoutedEventArgs e)
        {
            Db.openConnection();
            Db.sql = "Select *from Kullanıcılar";
            Db.cmd.CommandType = CommandType.Text;
            Db.cmd.CommandText = Db.sql;

            Db.da = new SqlDataAdapter(Db.cmd);
            Db.dt = new DataTable();
            Db.da.Fill(Db.dt);

            dataGrid.ItemsSource = Db.dt.DefaultView;
            
            Db.sql2 = "Select KullanıcıAdı from Kullanıcılar";
            Db.cmd2.CommandType = CommandType.Text;
            Db.cmd2.CommandText = Db.sql2;

            Db.da2 = new SqlDataAdapter(Db.cmd2);
            Db.dt2 = new DataTable();
            Db.da2.Fill(Db.dt2);
            dataGrid1.ItemsSource = Db.dt2.DefaultView;

            Db.closeConnetion();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            //Db.sql = "INSERT INTO kullanıcılar(Kullanıcı Adı,Sifre,Seviye) VALUES(@'" + this.textBox1.Text + "',@'" + this.textBox3.Text + "',@'" + this.textBox4.Text + "')";
            //Db.cmd.CommandType = CommandType.Text;
            //Db.cmd.CommandText = Db.sql;

            //Db.da = new SqlDataAdapter(Db.cmd);
            //Db.dt = new DataTable();
            //Db.da.Fill(Db.dt);

            //dataGrid.ItemsSource = Db.dt.DefaultView;
            //Db.closeConnetion();
            
            Db.sql = "INSERT INTO kullanıcılar(KullanıcıAdı,Sifre,Seviye) VALUES(@KullanıcıAdı,@Sifre,@Seviye)";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = textBox1.Text;
            Db.cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = textBox3.Text;
            Db.cmd.Parameters.Add("@Seviye", SqlDbType.NVarChar).Value = textBox4.Text;
            
        
            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            Window_Loaded(sender,e);



        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainn = new MainWindow();
            mainn.Show();
            Hide();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            malzeme malzeme1 = new malzeme();
            malzeme1.Show();
            Hide();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            malzeme2 malzeme22 = new malzeme2();
            malzeme22.Show();
            Hide();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Db.sql = "DELETE FROM kullanıcılar  WHERE KullanıcıAdı=@KullanıcıAdı";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = textBox5.Text;
           


            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            Window_Loaded(sender, e);
        }
        
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Db.sql = "UPDATE Kullanıcılar SET KullanıcıAdı=@KullanıcıAdı,Sifre=@Sifre,AdSoyad=@AdSoyad,Telefon=@Telefon,Eposta=@Eposta,Seviye=@Seviye WHERE KullanıcıID=@KullanıcıID";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;

            Db.cmd.Parameters.Clear();
            Db.cmd.Parameters.Add("@KullanıcıID", SqlDbType.NVarChar).Value = textBox8.Text;
            Db.cmd.Parameters.Add("@KullanıcıAdı", SqlDbType.NVarChar).Value = textBox7.Text;
            Db.cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = textBox6.Text;
            Db.cmd.Parameters.Add("@AdSoyad", SqlDbType.NVarChar).Value = textBox12.Text;
            Db.cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = textBox11.Text;
            Db.cmd.Parameters.Add("@Eposta", SqlDbType.NVarChar).Value = textBox10.Text;
            Db.cmd.Parameters.Add("@Seviye", SqlDbType.NVarChar).Value = textBox9.Text;

            Db.openConnection();
            Db.cmd.ExecuteNonQuery();
            Db.closeConnetion();
            Window_Loaded(sender, e);
        }
    }
}
