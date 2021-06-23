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

        private void button3_Click(object sender, EventArgs e)
        {
            İŞİSTASYONU işistasyonu = new İŞİSTASYONU();
         //   işistasyonu.MdiParent = this;
            işistasyonu.Show();
            this.Hide();
        }

      
    }
}
