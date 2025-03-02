using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler ogr1 = new Ogrenciler();
            ogr1.Ad = "ali";
            ogr1.Soyad = "topal";
            ogr1.tc = "54515382145";
            Ogrenciler ogr2 = new Ogrenciler();
            ogr2.Ad = "Veli";
            ogr2.Soyad = "Can";
            Console.WriteLine("***Ekran Çıktıları***");

            Console.WriteLine("birinci öğrenci ad: " + ogr1.Ad);
            Console.WriteLine("birinci öğrenci soyad: "+ogr1.Soyad);
            Console.WriteLine("ikinci öğrenci ad: " + ogr2.Ad);
            Console.WriteLine("ikinci öğrenci soyad: " + ogr2.Soyad);
            Console.WriteLine("Ad değiştirmek için giriniz");
            ogr1.Ad = Console.ReadLine();
            Console.WriteLine("birinci öğrenci adı: "+ogr1.Ad);
            Console.ReadKey();
        }
    }
}
