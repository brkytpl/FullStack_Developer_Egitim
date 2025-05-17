using System;
using System.Linq;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class IslemEkle : Form
    {
        public IslemEkle()
        {
            InitializeComponent();
        }
        Model1Container1 db=new Model1Container1();
        private void IslemEkle_Load(object sender, System.EventArgs e)
        {
            comboBox1.DataSource = db.KitaplarSet.Select(x => x.Yazar).Distinct().ToList();
            comboBox1.DisplayMember = "Yazar";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var liste = db.KitaplarSet.Where(x => x.Yazar == comboBox1.SelectedItem).ToList();
            comboBox2.DataSource = liste;
            comboBox2.DisplayMember = "KitapAdi";
            comboBox2.ValueMember = "KitapNo";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Sec sec = new Sec();
            sec.Show();
            this.Close();
        }
        //kaydet butonu
        private void button1_Click(object sender, System.EventArgs e)
        {
            Islemler kaydet=new Islemler();
            kaydet.UyelerTc = Convert.ToInt64(textBox1.Text);
            kaydet.KitaplarKitapNo = Convert.ToInt32(comboBox2.SelectedValue);
            kaydet.AlimTarihi = Convert.ToDateTime(textBox3.Text);
            kaydet.TeslimTarihi = Convert.ToDateTime(textBox4.Text);
            db.IslemlerSet.Add(kaydet);
            db.SaveChanges();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
