using System;
using System.Collections;
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

        Model1Container1 db=new Model1Container1();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = db.KitaplarSet.ToList();
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            dataGridView2.DataSource = db.UyelerSet.ToList();
            dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
            dataGridView3.DataSource=db.IslemlerSet.ToList();
            dataGridView3.Columns[dataGridView3.Columns.Count - 1].Visible = false;
            dataGridView3.Columns[dataGridView3.Columns.Count - 2].Visible = false;
        }
        //kitap ekle (+) butonu
        private void button3_Click(object sender, System.EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Hide();
        }

        //Kitaplar datagrid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if(e.ColumnIndex==0)
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
                KitapSil kitapSil = new KitapSil();
                kitapSil.Show();
                kitapSil.label1.Text = satir.Cells["KitapAdi"].Value.ToString();
                kitapSil.label1.Tag= satir.Cells["KitapNo"].Value.ToString();
                this.Hide();

            }

        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }
        //üue datagrid
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

            long Tc =Convert.ToInt64(textBox10.Text);
            var guncelle = db.UyelerSet.Where(x => x.Tc == Tc).FirstOrDefault();
            guncelle.Tc =Convert.ToInt64(textBox10.Text);
            guncelle.AdSoyad = textBox9.Text;
            guncelle.DTarihi =Convert.ToDateTime(textBox8.Text);
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

        private void button9_Click(object sender, EventArgs e)
        {
            IslemEkle ıslemEkle = new IslemEkle();
            ıslemEkle.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemEkle ıslemEkle=new IslemEkle();
            ıslemEkle.Show();
            this.Hide();
        }
        //İşlemler datagrid
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView3.CurrentRow;
            textBox14.Tag = satir.Cells["Id"].Value.ToString();
            textBox14.Text = satir.Cells["UyelerTc"].Value.ToString();
            textBox12.Text = satir.Cells["KitaplarKitapNo"].Value.ToString();
            textBox13.Text = satir.Cells["AlimTarihi"].Value.ToString();
            textBox15.Text = satir.Cells["TeslimTarihi"].Value.ToString();
            string teslimat = satir.Cells["Teslimat"].Value.ToString();

            if (teslimat == true.ToString()) 
            {
                checkBox1.Checked= true;

            }
            else
            {
                checkBox1.Checked = false;
            }
            dataGridView3.Columns[4].ReadOnly=true;


        }
        //İşlem güncelleme
        private void button10_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox14.Tag);
            var guncelle=db.IslemlerSet.Where(x=>x.Id==id).FirstOrDefault();
            guncelle.UyelerTc=Convert.ToInt64(textBox14.Text);
            guncelle.KitaplarKitapNo=Convert.ToInt32(textBox12.Text);
            guncelle.AlimTarihi=Convert.ToDateTime(textBox13.Text);
            guncelle.TeslimTarihi=Convert.ToDateTime(textBox15.Text);
            guncelle.Teslimat=checkBox1.Checked;
            db.SaveChanges();
            dataGridView3.DataSource=db.IslemlerSet.ToList();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //dataGridView3.DataSource=db.IslemlerSet.Where(x=>x.UyelerTc==Convert.ToInt64(textBox16.Text)).ToList();
        }
        //Ara butonu
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = db.IslemlerSet.Where(x => x.UyelerTc.ToString().Contains(textBox16.Text.ToString())).ToList();
        }

        private void textBox16_MouseDown(object sender, MouseEventArgs e)
        {
            textBox16.Text = string.Empty;
        }
        //İşlemler sil işlemi
        ArrayList secilenler=new ArrayList();
        private void button12_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir =new DataGridViewRow();
            for (int i = 0; i < dataGridView3.RowCount; i++) 
            {
                satir=dataGridView3.Rows[i];
                if (Convert.ToBoolean(satir.Cells[0].Value) == true)
                {
                    secilenler.Add(satir.Cells["id"].Value);
                }
            }
            foreach(int item in secilenler)
            {
                //int id = Convert.ToInt32(item);
                var sil = db.IslemlerSet.Where(x => x.Id== item).FirstOrDefault();
                db.IslemlerSet.Remove(sil);
                db.SaveChanges();

            }
            dataGridView3.DataSource = db.IslemlerSet.ToList();
        }
    }
}
