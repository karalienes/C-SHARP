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
    /// Login.xaml etkileşim mantığı
    /// </summary>
    
    
    public partial class Login : Window
    {
        public static SqlParameter p1, p2;
        public Login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
           
        {
            Db.openConnection();
            Db.sql = "Select KullanıcıAdı,Sifre From kullanıcılar where KullanıcıAdı=@KullanıcıAdı AND Sifre=@Sifre";
            Db.cmd.CommandText = Db.sql;
            Db.cmd.CommandType = CommandType.Text;
            p1 = new SqlParameter("KullanıcıAdı", textBox.Text.Trim());
            p2 = new SqlParameter("Sifre", textBox1.Text.Trim());
            Db.cmd2 = new SqlCommand(Db.sql, Db.con);
            Db.cmd2.Parameters.Add(p1);
            Db.cmd2.Parameters.Add(p2);

            Db.da = new SqlDataAdapter(Db.cmd2);
            Db.dt = new DataTable();
            Db.da.Fill(Db.dt);

            if (Db.dt.Rows.Count > 0)
            {
                MainWindow mainn = new MainWindow();
                mainn.Show();
                this.Hide();
            }
        }
    }
}
