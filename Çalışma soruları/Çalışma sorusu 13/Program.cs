using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] sayılar = new int[100]; // Maksimum 100 sayı depolamak için bir dizi oluşturduk.
            int sayıcı = 0;
            int numara;

            Console.WriteLine("Sayı üretme işlemi başlıyor...\n");

            do
            {
                numara = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üret.
                sayılar[sayıcı] = numara; // Sayıyı diziye ekle.
                sayıcı++;
                Console.WriteLine("Üretilen sayı: "+numara);
            } while (numara != 50); // 50 üretilene kadar devam et.

            Console.WriteLine("Sayı üretme işlemi sona erdi.");
            Console.WriteLine("Üretilen toplam sayı adedi:" +sayıcı);

            Console.WriteLine("Üretilen sayılar:");
            for (int i = 0; i < sayıcı; i++)
            {
                Console.Write(sayılar[i]);
                if (i < sayıcı - 1) Console.Write(", "); // Sayılar arasında virgül koy.
            }

        }
    }
}
