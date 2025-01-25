using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Klavyeden girilen 3 sayının içinden en küçüğünü bulan ve “En küçük sayı: ….” Şeklinde
            ekrana yazan program.*/
            Console.WriteLine("3 adet sayı giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            int sayi2=Convert.ToInt32(Console.ReadLine());
            int sayi3=Convert.ToInt32(Console.ReadLine());
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine("En küçük sayı {0}",sayi1);
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine("En küçük sayı {0}", sayi2);
            }
            else if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                Console.WriteLine("En küçük sayı {0}", sayi3);
            }
            Console.ReadKey();
        }
    }
}
