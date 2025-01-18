using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen 2 farklı sayıdan büyük olanı gösteren uygulama
            degeral:
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == sayi2)
            {
                Console.WriteLine("Lütfen 2 farklı sayı girin");
                goto degeral;
            }
            
            else
            {
                if (sayi1 > sayi2)
                {
                    Console.WriteLine("1. sayı büyüktür" + sayi1);

                }
                else
                {
                    Console.WriteLine("2.sayı büyüktür" + sayi2);
                }
            }
            Console.ReadKey();

        }
    }
}
