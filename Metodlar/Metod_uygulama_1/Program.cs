using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_uygulama_1
{
    internal class Program
    {
        public static void Toplama(double x, double y)
        {
            Console.WriteLine("Toplama sonucu: "+(x+y));
        }
        public static void Cikarma(double x, double y)
        {
            Console.WriteLine("Çıkarma işlemi: "+(x-y));
        }
        public static double Carpma(double x, double y)
        {
            return x * y;
        }
        public static double Bolme(double x, double y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("İşlem yapmak için 1. sayıyı giriniz");
            double sayi1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem yapmak için 2. sayıyı giriniz");
            double sayi2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama için 1\n Çıkarma için 2\n Çarpma için 3\n Bölme için 4'e basınız");
            git:
            byte cevap=Convert.ToByte(Console.ReadLine());
            if (cevap == 1)
            {
                Toplama(sayi1, sayi2);
            }
            else if (cevap == 2)
            {
                Cikarma(sayi1, sayi2);
            }
            else if (cevap == 3)
            {
                Console.WriteLine(Carpma(sayi1, sayi2));
            }
            else if (cevap == 4)
            {
                Console.WriteLine(Bolme(sayi1, sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
                goto git;
            }
            {
                
            }
            Console.ReadKey();
        }
    }
}
