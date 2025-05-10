using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_First_Prosedurlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        db_first_prosedurEntities3 con=new db_first_prosedurEntities3();
        private void button4_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = con.Araclars.ToList();
            dataGridView1.DataSource = con.Listeleme().ToList();
        }
        //kaydetme
        private void button1_Click(object sender, EventArgs e)
        {
            Araclar kaydet = new Araclar();
            kaydet.Marka=textBox1.Text;
            kaydet.Model=textBox2.Text;
            kaydet.Renk=textBox3.Text;
            //con.Araclars.Add(kaydet);
            //con.SaveChanges();
            con.Kaydetme(kaydet.Marka,kaydet.Model,kaydet.Renk);
            dataGridView1.DataSource = con.Listeleme().ToList();
        }
        //Güncelleme
        private void button2_Click(object sender, EventArgs e)
        {
            Araclar guncelle = new Araclar();
            guncelle.id=Convert.ToInt32(textBox1.Tag);
            guncelle.Marka=textBox1.Text;
            guncelle.Model=textBox2.Text;
            guncelle.Renk = textBox3.Text;
            con.Guncelleme(guncelle.id,guncelle.Marka,guncelle.Model,guncelle.Renk);
            dataGridView1.DataSource = con.Listeleme().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag= satir.Cells["id"].Value.ToString();
            textBox1.Text = satir.Cells["Marka"].Value.ToString();
            textBox2.Text = satir.Cells["Model"].Value.ToString();
            textBox3.Text = satir.Cells["Renk"].Value.ToString();
        }
        //Silme
        private void button3_Click(object sender, EventArgs e)
        {
            Araclar sil= new Araclar();
            sil.id=Convert.ToInt32(textBox1.Tag);
            con.Silme(sil.id);
            dataGridView1.DataSource = con.Listeleme().ToList();
        }
         //Ara
        private void button5_Click(object sender, EventArgs e)
        {
            Araclar ara= new Araclar();
            ara.Marka=textBox4.Text;
            dataGridView1.DataSource= con.Ara(ara.Marka).ToList();
        }
    }
}
