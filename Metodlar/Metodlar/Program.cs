using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class Program
    {
        //geriye değer döndürmeyen parametresiz metod
       public static void Toplama()
        {
            int x = 20;
            int y = 30;
            Console.WriteLine("sonuç:"+(x+y));
        }
        //Geriye değer döndürmeyen parametreli metod
        public static void Toplama2(int sayi1, int sayi2)
        {
            int sonuç = sayi1 + sayi2;
            Console.WriteLine("sonuç:"+sonuç);

        }
        //geriye değer döndüren parametresiz
        public static int Toplama3()
        {
            int x = 20;
            int y = 30;
            //return x + y;
            int sonuc = x + y;
            return sonuc;

        }
        //geriye değer döndüren parametreli
        public static int Toplama4(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Toplama();
            Toplama2(50, 60);
            Console.WriteLine(Toplama3());
            int x = Toplama3();
            Console.WriteLine(100+Toplama3());
            Console.WriteLine("sonuç:"+Toplama4(110,20));
            int y = 100;
            int z = 55;
            Toplama2(y, z);
            Toplama2(Toplama3(), y);


            Console.ReadKey();


        }
    }
}
