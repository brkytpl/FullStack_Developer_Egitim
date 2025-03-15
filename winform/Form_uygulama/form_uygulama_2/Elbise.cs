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
    public partial class Elbise : Form
    {
        public Elbise()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=textBox1.Text;
            float fiyat=Convert.ToSingle(textBox2.Text);
            string beden=comboBox1.Text;
            int adet=Convert.ToInt32(numericUpDown1.Value);
            listBox1.Visible = true;
            listBox1.Items.Add("Sayın: " + ad);
            listBox1.Items.Add("Fiyat: " + fiyat);
            listBox1.Items.Add("Beden: "+beden);
            listBox1.Items.Add("Adet: " + adet);
            listBox1.Items.Add("Tutar: "+(fiyat*adet));
        }
    }
}
