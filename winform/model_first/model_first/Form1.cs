using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container1()) // Context sınıfının adı olabilir
            {
                Araclar yeniArac = new Araclar()
                {
                    Marka = textBox1.Text,
                    Model = textBox2.Text,
                    Renk = textBox3.Text,
                };

                db.AraclarSet.Add(yeniArac);
                db.SaveChanges();
                MessageBox.Show("Araç eklendi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container1())
            {
                dataGridView1.DataSource = db.AraclarSet.ToList();
            }
        }

             

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Marka"].Value.ToString();
                textBox2.Text = row.Cells["Model"].Value.ToString();
                textBox3.Text = row.Cells["Renk"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (var db = new Model1Container1())
                {
                    var arac = db.AraclarSet.Find(id);
                    if (arac != null)
                    {
                        arac.Marka = textBox1.Text;
                        arac.Model = textBox2.Text;
                        arac.Renk = textBox3.Text;
                        db.SaveChanges();
                        MessageBox.Show("Araç güncellendi.");
                        dataGridView1.DataSource = db.AraclarSet.ToList();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (var db = new Model1Container1())
                {
                    var arac = db.AraclarSet.Find(id);
                    if (arac != null)
                    {
                        db.AraclarSet.Remove(arac);
                        db.SaveChanges();
                        MessageBox.Show("Araç silindi.");
                        dataGridView1.DataSource = db.AraclarSet.ToList();
                    }
                }
            }
        }
    }
    
}
