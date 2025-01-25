using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan iki değer arasındaki sayıların toplamını gösteren uygulama
            Console.WriteLine("Lütfen 2 adet değer giriniz");
            int toplam = 0;
            int sayi1=Convert.ToInt32(Console.ReadLine());
            int sayi2=Convert.ToInt32(Console.ReadLine());
            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam=toplam+i;
            }
            Console.WriteLine("Sayıların toplamı: "+toplam);
            Console.ReadKey();

        }
    }
}
