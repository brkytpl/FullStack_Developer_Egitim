using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random atanan 7 sayıyı bir dizide tutan ve bu sayılardan son rakamı 0 olanların
            toplamını bulan program*/

            Random random = new Random();
            int[] sayilar = new int[7];
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(10, 101);
            }

            Console.WriteLine("Rastgele üretilen sayılar:");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
                if (sayi % 10 == 0) 
                {
                    toplam += sayi;
                }
            }

            Console.WriteLine("\nSon Rakamı 0 Olan Sayıların Toplamı: " + toplam);

            Console.ReadKey();
        }
    }
}
