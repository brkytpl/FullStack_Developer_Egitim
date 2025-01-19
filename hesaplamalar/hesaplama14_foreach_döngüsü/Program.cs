using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama14_foreach_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Genellikle listeleme işlemlerinde kullanılır
            //Array(Diziler):Aynı tipte birden fazla değeri saklamak için kullanılır.
            //bir diziyi gezmek ve listelemk için foreach kullanılır,dizi ile ilgili işlem yapılacaksa for kullanılır

            int[] sayilar = { 6, 10, 15, 20, 4, 8 };
            //int[] sayilar2 = new int[5];
            //sayilar2[0] = 23;
            //sayilar2[1] = 12;
            //sayilar2[2] = 13;   
            //sayilar2[3] = 14;
            //sayilar2[4] = 15;
            //Console.WriteLine(sayilar2[4]);
            foreach (int i in sayilar) 
            {
                Console.WriteLine(i);
            }
            int[] sayilar2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("sayı giriniz");
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in sayilar2) 
            {
                Console.WriteLine("dizi elemanları:"+i);
            }
            string ad = "Berkay";
            foreach (char i in ad)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
