using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan girdiği sayıların toplamı 100 ü geçene kadar sayı isteyen toplam 100 geçtiği
            //anda kaç adet sayı girildiğini ve toplamın sonucunu ekrana yazan uygulama

            Console.WriteLine("Sayı giriniz");
            int toplam = 0;
            int adet = 0;
            for (int i=0;i<=100;i++)
            {
                if (toplam < 100)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    adet++;
                    toplam = toplam + sayi;
                    
                }
            }
            Console.WriteLine("Girilen sayı adeti: "+adet);
            Console.WriteLine("Sayıların toplamı: "+toplam);
            Console.ReadKey();

        }
    }
}
