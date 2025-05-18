using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }
        Model1Container1 db=new Model1Container1();
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.KitaplarSet.Where(x=>x.KitapAdi==textBox1.Text).ToList();
            //var sonuc =  db.KitaplarSet.Where(x => x.KitapAdi == textBox1.Text);
            //dataGridView1.DataSource =sonuc.ToList();
            
            //var sonuc=from x in db.KitaplarSet where x.KitapAdi==textBox1.Text select x;
            //dataGridView1.DataSource = sonuc.ToList();

            //dataGridView1.DataSource= (from x in db.KitaplarSet where x.KitapAdi == textBox1.Text select x).ToList();

            //var sonuc = from x in db.KitaplarSet
            //            where x.KitapAdi == textBox1.Text
            //            select new
            //            {
            //                x.KitapAdi,
            //                x.BasimYili
            //            };
            //dataGridView1.DataSource = sonuc.ToList();

            var sonuc = db.KitaplarSet.Where(x => x.KitapAdi == textBox1.Text).Select(y => new {y.KitapAdi,y.BasimYili});
            dataGridView1.DataSource = sonuc.ToList();

        }
        //A dan z ye sıralama
        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc=from uye in db.UyelerSet orderby uye.AdSoyad ascending select uye;
            dataGridView1.DataSource= sonuc.ToList();
        }
        //İşlemlerin yeni tarihtan eski tarihe doğru sıralaması
        private void button3_Click(object sender, EventArgs e)
        {
            var sonuc=from x in db.IslemlerSet orderby x.AlimTarihi descending select x;
            dataGridView1 .DataSource= sonuc.ToList();
        }
        //Basım yılı 2010 dan önce olan Kitapların Listesi(CompareTo)
        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = db.KitaplarSet.Where(x => x.BasimYili.CompareTo(2010) <= 0);
            dataGridView1.DataSource=sonuc.ToList();
        }
        //Basım yılı 2010 dan Sonra olan Serap Yazarının Kitapları
        private void button5_Click(object sender, EventArgs e)
        {
            var sonuc = db.KitaplarSet.Where(x => x.BasimYili.CompareTo(2010)>0 && x.Yazar.Contains("Serap"));
            dataGridView1.DataSource=sonuc.ToList();
        }
        //Basım Yılı 1900 den sonra olan yazar grupları
        private void button6_Click(object sender, EventArgs e)
        {
            //var sonuc =db.KitaplarSet.Where(x=>x.BasimYili>1900).GroupBy(y=>y.Yazar).ToList();
            //dataGridView1.DataSource=sonuc;

            //var sonuc = from x in db.KitaplarSet where x.BasimYili > 1900 group x.Yazar by x.Yazar;
            //dataGridView1.DataSource=sonuc.ToList();

            var sonuc = db.KitaplarSet.GroupBy(y => y.Yazar).Select(x=>new {Yazarlar=x.Key,KitapAdedi=x.Count()});
            dataGridView1.DataSource = sonuc.ToList();
        }
        //Uyeler ve işlemler Join
        private void button7_Click(object sender, EventArgs e)
        {
            //select * from Uyelerset as x join Islemlerset as y on x.Tc=y.UyeTc
            var sonuc = from x in db.UyelerSet join y in db.IslemlerSet on x.Tc equals y.UyelerTc select new {x.AdSoyad,y.AlimTarihi,y.Teslimat};
            dataGridView1.DataSource=sonuc.ToList();
        }
        //Üyelerin aldıkları kitapların adları ile beraber alım tarihleri ve teslimat durumlarının listesi
        //Uyeler,İşlemler,Kitaplar Join
        private void button8_Click(object sender, EventArgs e)
        {
            var sonuc = from x in db.UyelerSet
                        join y in db.IslemlerSet on x.Tc equals y.UyelerTc
                        join z in db.KitaplarSet on y.KitaplarKitapNo equals z.KitapNo
                        orderby x.AdSoyad ascending
                        select new
                        {
                            x.AdSoyad,
                            z.KitapAdi,
                            y.AlimTarihi,
                            y.Teslimat,
                        };
            dataGridView1.DataSource=sonuc.ToList();
        }
    }
}
