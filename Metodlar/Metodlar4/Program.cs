using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar4
{
    internal class Program
    {
        static byte secim;
        static int fiyat;
        public static int indirim(byte secim, int fiyat)
        {
            if (secim == 1)
            {
                return fiyat - ((fiyat * 20) / 100);
            }
            else
            {
                return fiyat - ((fiyat * 5) / 100);
            }
        }
        /*public static void fis(int ürünfiyati)
        {
            int sonuc = ürünfiyati + ((ürünfiyati * 20) / 100);
            Console.WriteLine("ödenecek tutar: "+sonuc);
        }*/
        public static void fis()
        {
            int tutar = indirim(secim, fiyat);
            int sonuc = tutar + tutar * 20 / 100;
            Console.WriteLine("ödenecek fiyat: " + sonuc);

        }
        static void Main(string[] args)
        {
            //Ana ekranda seçim yapılacak
            //1- mutfak ürünleri
            //2- mobilyalar
            //indirim hesaplayan metod(mutfak ürünlerine %20, mobilya %5)
            //indirimli tutarla kdv hesaplayan fiş metodu olsun
            //kullanıcısının ödeyeceği fiyat çıktı olarak sunulsun
            Console.WriteLine("Mutfak ürünleri için 1\nMobilya için 2'ye basınız");
            secim=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ürün fiyatı");
            fiyat=Convert.ToInt32(Console.ReadLine());
            //fis(indirim(secim, fiyat));//fis 800
            fis();
            Console.ReadLine();
        }
    }
}
