using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen1 = new Ogretmen();//nesne ürettik
            ogretmen1.ad = "ali";
            ogretmen1.brans = "Matematik";
            ogretmen1.maas = 40000;
            Ogretmen ogretmen2 = new Ogretmen();//2. nesne üretildi
            ogretmen2.ad = "veli";
            ogretmen2.brans = "Türkçe";
            ogretmen2.maas = 50000;
            Ogrenciler ogrenci1 = new Ogrenciler();//classtan nesne ürettik
            Console.WriteLine("Öğrenci ad giriniz");
            ogrenci1.ad=Console.ReadLine();
            Console.WriteLine("Öğrenci no giriniz");
            ogrenci1.no=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sınıf giriniz");
            ogrenci1.sinif=Console.ReadLine();
            Okul.adres = "atatürk okulu";//nesne üretmeden static clasa direk eriştik
            Okul okul1 = new Okul();
            

            Console.WriteLine("**********************************************");

            Console.WriteLine(ogretmen1.ad);
            Console.WriteLine(ogretmen1.brans);
            Console.WriteLine(ogrenci1.ad);
            Console.WriteLine(ogrenci1.sinif);
            ogretmen1.BilgiAl();
            Console.ReadLine();
        }
    }
}
