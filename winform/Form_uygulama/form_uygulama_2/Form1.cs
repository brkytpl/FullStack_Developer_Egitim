using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k_ad = "Berkay";
            string parola = "123a";
            if (k_ad == textBox1.Text && parola == textBox2.Text)
            {
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
        }
    }
}
