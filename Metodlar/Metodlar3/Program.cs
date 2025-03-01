using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar3
{
    internal class Program
    {
        public static void Hesapla(string ad,char cinsiyet, int dogumyili)
        {
            int yas=2025-dogumyili;
            if(cinsiyet=='E'|| cinsiyet=='e')
            {
                if(yas>=40)
                {
                    Console.WriteLine("Sayın "+ad+" Başvuru kabul edildi");
                }
                else
                {
                    Console.WriteLine("Sayın " + ad + " Başvuru kabul edilmedi");
                }
            }
            else
            {
                if (yas >= 30)
                {
                    Console.WriteLine("Sayın " + ad + " Başvuru kabul edildi");
                }
                else
                {
                    Console.WriteLine("Sayın " + ad + " Başvuru kabul edilmedi");
                }
            }
        }
        static void Main(string[] args)
        {
            //kullanıcıdan ad, cinsiyet ve doğum yılı bilgilerini alıp
            //yaş hesaplaması yapan metod kullanarak cinsiyeti erkek ise yaşıda
            //40 dan büyükse başvurusunu kabul eden
            //cinsiyet kadın ise yaşı 30 dan büyükse başvuru kabul eden uygulama

            Console.WriteLine("Adınız:");
            string ad=Console.ReadLine();
            Console.WriteLine("Cinsiyet E/K");
            char cinsiyet=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Doğum yılı:");
            int yil=Convert.ToInt32(Console.ReadLine());
            Hesapla(ad, cinsiyet, yil );
        }
    }
}
