using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        Model1Container1 db = new Model1Container1();
        //Giriş butonu kullanıcı adı uyeler tablosundaki ad soy ad şifre ise tc dir.
        private void button1_Click(object sender, EventArgs e)
        {
            int tc=Convert.ToInt32(textBox2.Text);
            var login=from x in db.UyelerSet where x.AdSoyad==textBox1.Text && x.Tc==tc select x;
            var login2=db.UyelerSet.Where(x=>x.AdSoyad.Equals(textBox1.Text) && x.Tc.Equals (tc));
            if (login!=null) 
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("giriş yapılmadı");
            }
        }
    }
}
