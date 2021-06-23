using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÇALIŞAN çalışan = new ÇALIŞAN();
            çalışan.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            REÇETE reçete = new REÇETE();
            reçete.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İŞİSTASYONU işistasyonu = new İŞİSTASYONU();
            işistasyonu.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OPERASYON operasyon = new OPERASYON();
            operasyon.Show();
            Hide();
        }

        
    }
}
