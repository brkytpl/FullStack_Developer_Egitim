using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_Sorusu_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden 10 rakamını girene kadar kullanıcıdan sayı almaya devam eden ve alınan
            sayıların ortalamasını hesaplayıp gösteren uygulama*/
            
            int girilensayisayisi = 0;
            double ortalama;
            double toplam = 0;
        git:
            Console.WriteLine("Sayı giriniz");
            int Sayi= Convert.ToInt32(Console.ReadLine());
            if (Sayi != 10)
            {
                girilensayisayisi++;
                toplam=toplam+Sayi;
                ortalama=toplam/girilensayisayisi;
                Console.WriteLine("Sayıların ortalaması= "+ortalama);
                goto git;
            }
            Console.ReadKey();
           
        }
    }
}
