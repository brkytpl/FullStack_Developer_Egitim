using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karar kontrol mekanizmaları
            // if else, switch case
            // Girilen 2 motun ortalaması 50 den büyükse iyi değilse kötü yazan uygulma
            Console.WriteLine("1.Notu giriniz");
            byte not1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("2.Notu giriniz");
            byte not2 = Convert.ToByte(Console.ReadLine());
            float sonuc = (not1 + not2) / 2;

            if (sonuc > 50)
            {
                Console.WriteLine("iyi");

            }
            else
            {
                Console.WriteLine("kötü");
            }
            Console.ReadKey();
        }
    }
}