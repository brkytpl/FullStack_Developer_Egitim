using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatayakalama
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            //label1.Text=Convert.ToString(sayi1+ sayi2);
            
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sayi3;
                label1.Text = (sayi1 / sayi2).ToString();
            }
            //catch (FormatException hata)
            //{
            //    MessageBox.Show(hata.Message)
            //}
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayı giriniz");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("0 sayısına bölme yapılmaz \n" + ex.Source+"\n"+ex.Message);
            }
            catch 
            {
                MessageBox.Show("hata oluştu işlemi kontrol ediniz");            }
            finally 
            {
                label1.Text = "işlem tamamlandı";
            }

        }
    }
}
