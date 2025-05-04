using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst_Prosedursuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GaleriEntities connection = new GaleriEntities();//veritabanı bağlantısı
        //Kaydet Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Araclar kaydet = new Araclar();
            kaydet.Marka = textBox1.Text;
            kaydet.Model = textBox2.Text;
            kaydet.Aksesuar = textBox3.Text;
            kaydet.Renk = textBox4.Text;
            kaydet.Tip = textBox5.Text;
            kaydet.Fiyat = Convert.ToDecimal(textBox6.Text);
            connection.Araclars.Add(kaydet);//Araçlar tablosu listesine ekler
            connection.SaveChanges();//veritabanına tüm değişiklikleri kaydeder.
            dataGridView1.DataSource = connection.Araclars.ToList();
        }
        //Listeleme
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connection.Araclars.ToList();//Listeleme işlemi
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["id"].Value.ToString();
            textBox1.Tag = row.Cells["Marka"].Value.ToString();
            textBox2.Tag = row.Cells["Model"].Value.ToString();
            textBox3.Tag = row.Cells["Aksesuar"].Value.ToString();
            textBox4.Tag = row.Cells["Renk"].Value.ToString();
            textBox5.Tag = row.Cells["Tip"].Value.ToString();
            textBox6.Tag = row.Cells["Fiyat"].Value.ToString();
        }
        //Sil butonu
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);

            var sonuc = connection.Araclars.Where(x => x.id == id).FirstOrDefault();//find veya first metodlarıda kullanılabilir.
            connection.Araclars.Remove(sonuc);
            connection.SaveChanges();
            dataGridView1.DataSource = connection.Araclars.ToList();

        }
        //Güncelleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);

            var sonuc = connection.Araclars.Where(x => x.id == id).FirstOrDefault();//find veya first metodlarıda kullanılabilir.
            sonuc.Marka = textBox1.Text;
            sonuc.Model = textBox2.Text;
            sonuc.Aksesuar = textBox3.Text;
            sonuc.Renk = textBox4.Text;
            sonuc.Tip = textBox5.Text;
            sonuc.Fiyat = Convert.ToDecimal(textBox6.Text);
            connection.SaveChanges();
            dataGridView1.DataSource = connection.Araclars.ToList();
        }
    }

}
