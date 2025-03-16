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
    public partial class Sipariş: Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }

        private void Sipariş_Load(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            listBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Müşteri Bilgileri");
            listBox1.Items.Add("Ad Soyad: "+textBox1.Text);
            listBox1.Items.Add("Ödeme Şekli: "+comboBox1.Text);
            listBox1.Items.Add("Telefon: "+maskedTextBox1.Text);
            listBox1.Items.Add("Adres: "+textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            comboBox1.Text = "";//clear metodu olmadığı için böyle yaptık
            groupBox1.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Lahmacun")
            {
                groupBox3.Show();
                groupBox2.Hide();
            }
            else if(comboBox2.SelectedItem.ToString() =="Kebap")
            {
                groupBox2.Show();
                groupBox3.Hide();
            }
            /*if (comboBox2.SelectedIndex == 0) 
            {}*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            foreach (var i in listBox1.Items) 
            {
                fis.listBox1.Items.Add(i);
            }
            fis.listBox1.Items.Add("Yemek Bilgileri");
            if (checkBox1.Checked == true)
            {
                int adet =Convert.ToInt32( numericUpDown1.Value);
                int fiyat = 150;
                fis.listBox1.Items.Add(adet + " Adet Adana Fiyat: " + fiyat * adet);
            }
            if (checkBox2.Checked == true)
            {
                int adet = Convert.ToInt32(numericUpDown2.Value);
                int fiyat = 100;
                fis.listBox1.Items.Add(adet + " Adet Urfa Fiyat: " + fiyat * adet);
            }
            if (checkBox3.Checked == true)
            {
                int adet = Convert.ToInt32(numericUpDown4.Value);
                int fiyat = 60;
                fis.listBox1.Items.Add(adet + " Adet Acılı Lahmacun Fiyat: " + fiyat * adet);
            }
            if (checkBox4.Checked == true)
            {
                int adet = Convert.ToInt32(numericUpDown3.Value);
                int fiyat = 50;
                fis.listBox1.Items.Add(adet + " Adet Acısız Lahmacun Fiyat: " + fiyat * adet);
            }
            fis.Show();
            if (comboBox3.SelectedIndex == 0)
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString() + "fiyat: " + (15 * Convert.ToUInt32(numericUpDown5.Value)));
            }
            else if (comboBox3.SelectedIndex == 1) 
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString() + "fiyat: " + (5 * Convert.ToUInt32(numericUpDown5.Value)));
            }
            else if(comboBox3.SelectedIndex == 2)
            {
                fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem.ToString() + "fiyat: " + (30 * Convert.ToUInt32(numericUpDown5.Value)));
            }
            else
            {
                fis.listBox1.Items.Add("İçecek seçimi yapılmadı.");

            }
        }
    }
}
