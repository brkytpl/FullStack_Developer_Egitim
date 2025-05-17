using System;
using System.Linq;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1Container2 db=new Model1Container2();
        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = db.KitaplarSet.ToList();
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            dataGridView2.DataSource = db.UyelerSet.ToList();
            dataGridView1.Columns[dataGridView2.Columns.Count - 1].Visible = false;
            dataGridView3.DataSource= db.IslemlerSet.ToList();
            dataGridView1.Columns[dataGridView3.Columns.Count - 1].Visible = false;
            dataGridView1.Columns[dataGridView3.Columns.Count - 2].Visible = false;


        }
        //kitap ekle (+) butonu
        private void button3_Click(object sender, System.EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir=dataGridView1.CurrentRow;
            if(e.ColumnIndex == 0)
            {
                KitapGuncelle kitapGuncelle = new KitapGuncelle();
                kitapGuncelle.Show();
                kitapGuncelle.textBox1.Text = satir.Cells["KitapNo"].Value.ToString();
                kitapGuncelle.textBox2.Text = satir.Cells["KitapAdi"].Value.ToString();
                kitapGuncelle.textBox3.Text = satir.Cells["Yazar"].Value.ToString();
                kitapGuncelle.textBox4.Text = satir.Cells["BasimYili"].Value.ToString();
                this.Hide();

            }
            if (e.ColumnIndex == 1) 
            {
                KitapSil kitapSil= new KitapSil();
                kitapSil.Show();
                kitapSil.label1.Text = satir.Cells["KitapAdi"].Value.ToString();
                kitapSil.label1.Tag= satir.Cells["KitapNo"].Value.ToString();
            }
        }
        //Üye ekle butonu
        private void button6_Click(object sender, System.EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            uyeEkle.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            textBox10.Text = satir.Cells["Tc"].Value.ToString();
            textBox9.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox8.Text = satir.Cells["DTarihi"].Value.ToString();
            textBox11.Text = satir.Cells["Telefon"].Value.ToString();
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            long Tc = Convert.ToInt64(textBox10.Text);
            var guncelle=db.UyelerSet.Where(x=>x.Tc == Tc).FirstOrDefault();
            guncelle.Tc=Convert.ToInt64(textBox10.Text);
            guncelle.AdSoyad=textBox9.Text;
            guncelle.Dtarihi =Convert.ToDateTime(textBox8.Text);
            guncelle.Telefon = textBox11.Text;
            db.SaveChanges();
            dataGridView2.DataSource = db.UyelerSet.ToList();
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            long Tc = Convert.ToInt64(textBox10.Text);
            var guncelle = db.UyelerSet.Where(x => x.Tc == Tc).FirstOrDefault();
            db.UyelerSet.Remove(guncelle);
            db.SaveChanges();
            dataGridView2.DataSource = db.UyelerSet.ToList();
        }
    }
}
