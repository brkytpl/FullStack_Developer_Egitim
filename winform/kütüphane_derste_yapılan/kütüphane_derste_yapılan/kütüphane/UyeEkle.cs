using System;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class UyeEkle : Form
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
        public UyeEkle()
        {
            InitializeComponent();
        }

        Model1Container1 db=new Model1Container1();

        private void button1_Click(object sender, System.EventArgs e)
        {
            Uyeler kaydet= new Uyeler();
            kaydet.Tc = Convert.ToInt64(textBox1.Text);
            kaydet.AdSoyad=textBox2.Text;
            kaydet.DTarihi=Convert.ToDateTime(textBox3.Text);
            kaydet.Telefon = textBox5.Text;
            db.UyelerSet.Add(kaydet);
            db.SaveChanges();
            MessageBox.Show("kayıt yapıldı");
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
