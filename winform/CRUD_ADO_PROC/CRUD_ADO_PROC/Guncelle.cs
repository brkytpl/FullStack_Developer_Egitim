﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ADO_PROC
{
    public partial class Guncelle: Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=magaza;integrated security=true");
        //Güncelle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("sGuncelle", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", textBox1.Tag);
            cmd.Parameters.AddWithValue("musteri", textBox1.Text);
            cmd.Parameters.AddWithValue("urun", textBox2.Text);
            cmd.Parameters.AddWithValue("fiyat",Convert.ToDecimal(textBox3.Text));
            cmd.Parameters.AddWithValue("adet", Convert.ToInt32(textBox4.Text));
            cmd.Parameters.AddWithValue("odeme", textBox5.Text);
            cmd.ExecuteNonQuery();

            connection.Close();

            this.Close();
        }
    }
}
