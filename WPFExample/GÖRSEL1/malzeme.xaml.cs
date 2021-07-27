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
    /// malzeme.xaml etkileşim mantığı
    /// </summary>
    public partial class malzeme : Window
    {
        public malzeme()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Db.openConnection();
            Db.sql = "Select *from Malzemeler";
            Db.cmd.CommandType = CommandType.Text;
            Db.cmd.CommandText = Db.sql;

            Db.da = new SqlDataAdapter(Db.cmd);
            Db.dt = new DataTable();
            Db.da.Fill(Db.dt);

            dataGrid.ItemsSource = Db.dt.DefaultView;

            Db.closeConnetion();
        }

        private void Window_Loaded1(object sender, RoutedEventArgs e)
        {
            Db.openConnection();
            Db.sql = "Select *From malzemeler where MalzemeAdı like '%" + textBox.Text + "%' ";
            Db.cmd.CommandType = CommandType.Text;
            Db.cmd.CommandText = Db.sql;

            Db.da = new SqlDataAdapter(Db.cmd);
            Db.dt = new DataTable();
            Db.da.Fill(Db.dt);

            dataGrid.ItemsSource = Db.dt.DefaultView;

            Db.closeConnetion();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            malzeme2 malzeme222 = new malzeme2();
            malzeme222.Show();
            Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            malzeme malzeme11 = new malzeme();
            malzeme11.Show();
            Hide();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainn1 = new MainWindow();
            mainn1.Show();
            Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Db.openConnection();
            Db.sql = "Select *From malzemeler where MalzemeAdı like '%" + textBox.Text + "%' ";
            Db.cmd.CommandType = CommandType.Text;
            Db.cmd.CommandText = Db.sql;

            Db.da = new SqlDataAdapter(Db.cmd);
            Db.dt = new DataTable();
            Db.da.Fill(Db.dt);

            dataGrid.ItemsSource = Db.dt.DefaultView;

            Db.closeConnetion();
        }
    }
}
