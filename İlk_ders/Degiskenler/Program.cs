using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 12;
            int y = 5;
            float z = 6.5f;
            double t = 11.75;
            decimal k = 125.56m;
            char metin = 'E';
            string ad = "Berkay";
            bool cevap = false;
            Console.WriteLine("hello world");
            Console.WriteLine(x);
            Console.WriteLine("x den gelen değer:" + x);
            Console.WriteLine("y değişkeninden gelen değer:{0}", y);
            Console.WriteLine("Birinci sayı:{0} İkinci sayı:{1}", z, t);
            Console.WriteLine("birinci sayı:" + z + " İkinci sayı:" + t);
            Console.WriteLine("Adınız Nedir?");
            string isim = Console.ReadLine();
            Console.WriteLine("Girilen isim:" + isim);

            Console.WriteLine("birinci sayıyı giriniz:");
            Double sayi1 = Convert.ToInt32(Console.ReadLine());//Tür dönüşümü için kullanılır. 
            Console.WriteLine("ikinci sayıyı giriniz:");
            Double sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi1 + sayi2);
            double sonuc5 = sayi1 / sayi2;
            Console.WriteLine(sonuc5);

            Console.WriteLine("sayı giriniz");
            Double sayı = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yüzde oranı giriniz");
            byte yuzde = Convert.ToByte(Console.ReadLine());

            Double sonuc = sayı + (sayı * yuzde / 100);
            Console.WriteLine(sonuc);
            decimal sonuc2 = Convert.ToDecimal(sayı + (sayı * yuzde / 100));
            decimal sonuc3 = (decimal)(sayı + sayı * yuzde / 100);
            int sonuc4 = (int)(sayı + sayı * yuzde / 100);

            Console.ReadKey();
        }
    }
}
