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
    public partial class Kayit_ekrani: Form
    {
        public Kayit_ekrani()
        {
            InitializeComponent();
        }
        private void Kayit_ekrani_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kitap Bilgileri");
            listBox1.Items.Add("Kitabın Adı: "+ textBox1.Text);
            listBox1.Items.Add("Kitabın Yazarı: " + textBox2.Text);
            listBox1.Items.Add("Basım Yılı: "+textBox3.Text);
            listBox1.Items.Add("Bulunduğu Kat: " + comboBox1.Text);
            listBox1.Items.Add("Bulunduğu Rad: " + textBox5.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox5.Clear();
            groupBox1.Hide();


            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit_Fisi kayit_Fisi = new Kayit_Fisi();
            foreach (var item in listBox1.Items)
            {
                kayit_Fisi.listBox1.Items.Add(item);
            }
            kayit_Fisi.Show();
        }
    }
}
