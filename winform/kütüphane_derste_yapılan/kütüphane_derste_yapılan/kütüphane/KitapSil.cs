using System;
using System.Linq;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class KitapSil : Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }
        Model1Container1 db=new Model1Container1();
       //Evet Butonu
        private void button1_Click(object sender, System.EventArgs e)
        {
            int kitapno = Convert.ToInt32(label1.Tag);
            var sil = db.KitaplarSet.Where(x => x.KitapNo == kitapno).FirstOrDefault();
            db.KitaplarSet.Remove(sil);
            db.SaveChanges();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
        //Hayır butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
