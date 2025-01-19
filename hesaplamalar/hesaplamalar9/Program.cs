using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplamalar9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random: rastgele değer üretecek
            //random bir classtır .net kütüphanesinden
            Random rasgelesayi = new Random();//classtan nesne üretmek
            
            for (int i = 0; i < 5; i++)
            {
                int sayi = rasgelesayi.Next(10, 50);
                Console.WriteLine(sayi);
            }



            Console.ReadKey();
        }
    }
}
