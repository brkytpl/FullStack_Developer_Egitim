using System;
using System.Linq;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }

        Model1Container1 db= new Model1Container1();
        //güncelle butonu
        private void button1_Click(object sender, System.EventArgs e)
        {
            int kitapno = Convert.ToInt32(textBox1.Text);
            var guncelle = db.KitaplarSet.Where(x => x.KitapNo == kitapno).FirstOrDefault();
           
            guncelle.KitapAdi = textBox2.Text;
            guncelle.Yazar = textBox3.Text;
            guncelle.BasimYili = Convert.ToInt16(textBox4.Text);
            db.SaveChanges();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        // Kapat
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
