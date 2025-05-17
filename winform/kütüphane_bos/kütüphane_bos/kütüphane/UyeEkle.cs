using System;
using System.ComponentModel.DataAnnotations;
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
        Model1Container2 db=new Model1Container2();
        private void button1_Click(object sender, System.EventArgs e)
        {
            Uyeler kaydet= new Uyeler();
            kaydet.Tc = Convert.ToInt64(textBox1.Text);
            kaydet.AdSoyad = textBox2.Text;
            kaydet.Dtarihi=Convert.ToDateTime(textBox3.Text);
            kaydet.Telefon=textBox4.Text;
            db.UyelerSet.Add(kaydet);
            db.SaveChanges();
            MessageBox.Show("Kayıt yapıldı");
            Temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Close();
        }
    }
}
