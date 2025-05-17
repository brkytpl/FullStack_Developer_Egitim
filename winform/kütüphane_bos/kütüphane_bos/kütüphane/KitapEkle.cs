using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class KitapEkle : Form
    {
        public void Temizle()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox) 
                {
                    x.Text = "";
                }
            }
        }
        public KitapEkle()
        {
            InitializeComponent();
        }
            Model1Container2 db = new Model1Container2();
        private void button1_Click(object sender, System.EventArgs e)
        {
            Kitaplar kaydet= new Kitaplar();
            kaydet.KitapNo=Convert.ToInt32(textBox1.Text);
            kaydet.KitapAdi = textBox2.Text;
            kaydet.Yazar = textBox3.Text;
            kaydet.BasimYili = Convert.ToInt16(textBox4.Text);
            db.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text=string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Close();
        }
    }
}
