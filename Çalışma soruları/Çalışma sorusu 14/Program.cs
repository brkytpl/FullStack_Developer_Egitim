using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen boy ve cinsiyet bilgilerine göre kişinin ideal kilosunu aşağıdaki
açıklamaya göre hesaplayıp ekrana “İdeal Kilonuz=...” şeklinde yazdırınız.
Not: Hesaplama Kadın için ayrı erkek için ayrı aşağıdaki bilgilere göre yapılık ekrana
yazdırılacak.
Kadınlar için: Boyunuzun ilk 150 santimetresi için 45 kilo, sonraki her 2.5 cm için 2.2 kilo
ekler.
Örnek olarak; boyunuz 160 cm ise, ideal kilonuz 45+8.8=53.8 kilogram olacaktır.
Erkekler için: Boyunuzun ilk 150 santimetresi için 48 kilo, sonraki her 2.5 cm için 2.7 kilo
ekler.
Örnek olarak boyunuz 180 cm ise, ideal kilonuz 48+32.4=80.4 kilogram olacaktır*/
            git:
            Console.WriteLine("Cinsiyetinizi giriniz");
            string cinsiyet=Console.ReadLine();
            Console.WriteLine("Boyunuzu giriniz");
            int boy=Convert.ToInt32(Console.ReadLine());
            double kalanboy;
            double kalancm;
            double idealKilo;
            switch (cinsiyet)
            {
                case "kadın":
                    if (boy <= 150)
                    {
                        Console.WriteLine("İdeal kilonuz 45 kg dır.");
                    }
                    else if (boy > 150)
                    {
                        kalanboy=boy - 150;
                        kalancm = kalanboy / 2.5;
                        idealKilo = 45 + (kalancm * 2.2);
                        Console.WriteLine("Boyunuz {0} cm ideal kilonuz {1}",boy, idealKilo);
                    }
                        break;
                case "erkek":
                    if (boy <= 150)
                    {
                        Console.WriteLine("İdeal kilonuz 48 kg dır.");
                    }
                    else if (boy > 150)
                    {
                        kalanboy = boy - 150;
                        kalancm = kalanboy / 2.5;
                        idealKilo = 48 + (kalancm * 2.7);
                        Console.WriteLine("Boyunuz {0} cm ideal kilonuz {1}", boy, idealKilo);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Cinsiyeti hatalı girdiniz");
                        goto git;

                    }
                                   
            }
            Console.ReadKey();


        }
    }
}
