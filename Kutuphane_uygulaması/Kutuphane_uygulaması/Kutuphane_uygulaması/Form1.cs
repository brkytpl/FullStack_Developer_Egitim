using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = "Berkay";
            string sifre = "123berkay";
            if (ad == textBox1.Text && sifre == textBox2.Text)
            {
                Kayit_ekrani kayit_Ekrani = new Kayit_ekrani();
                kayit_Ekrani.Show();
            }
            else 
            {
                label4.Text="Eksik giriş yaptınız";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/brkytpl");
        }
    }
}
