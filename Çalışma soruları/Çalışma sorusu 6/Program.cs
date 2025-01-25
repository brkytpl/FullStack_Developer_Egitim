using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak kullanıcıdan istenilen sayıya kadar olan sayıların toplamının sonucu
            //bulacak uygulama

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayı=Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i <= sayı; i++)
            {
                toplam = toplam+i;
            }
            Console.WriteLine("Sayıların toplamı: "+toplam);
            Console.ReadKey();
        }
    }
}
