using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formuygulama3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.ibb.gov.tr");
        }
        string ad = "Berkay";
        string parola = "123a";

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad == textBox1.Text && parola == textBox2.Text) 
            {
                Sipariş sipariş = new Sipariş();
                sipariş.Show();
                sipariş.label1.Text="Hoşgeldin "+ textBox1.Text;
            }
        }
    }
}
