using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar5_ref
{
    internal class Program
    {
        public static void hesaplama(int x)
        {
            x += 50;
            Console.WriteLine("metodun hesapladığı sayı: "+x);

        }
        public static void hesaplama2(ref int x)
        {
            x += 50;
            Console.WriteLine("metodun hesapladığı sayı: " + x);
        }
        static void Main(string[] args)
        {
            int sayi = 30;
            Console.WriteLine("metot çalışmadan önce sayı değikeni: "+sayi);
            hesaplama(sayi);
            Console.WriteLine("metod ile parametre olarak kullanıldıktan sonra sayı değişkeni: "+sayi);
            hesaplama2(ref sayi);
            Console.WriteLine("metod ile parametre olarak kullanıldıktan sonra sayı değişkeni: " + sayi);
            Console.ReadLine();
        }
    }
}
