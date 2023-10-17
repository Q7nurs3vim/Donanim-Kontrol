using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donanım_Bİrimleri_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            secim=listBox1.SelectedItem.ToString();
            if(secim=="Mouse"|| secim=="Klavye"|| secim == "Kamera" || secim == "Tarayıcı")
            {
                MessageBox.Show("Bu parça giriş birimidir.");
            {
             if(secim=="Yazıcı"|| secim=="Hoparlör"|| secim == "Projeksiyon")
            {
                MessageBox.Show("Bu parça çıkış birimidir.");
            }
            }

            }
        }
    }
}
