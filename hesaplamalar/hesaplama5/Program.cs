using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kontrol mekanizması switch case
            //
            Console.WriteLine("1.sayıyı gir");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            secim:
            Console.WriteLine("toplama işlemi için 1");
            Console.WriteLine("çıkarma işlemi için 2");
            Console.WriteLine("çarpma işlemi için 3");
            Console.WriteLine("bölme işlemi için 4 e basınız");
            byte secim = Convert.ToByte(Console.ReadLine());
            int sonuc;
            switch (secim)
            {
                case 1:
                    {
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("toplamı=" + sonuc);
                        break;
                    }
                    case 2:
                    {
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Çıkarma=" + sonuc);
                        break;
                    }
                    case 3:
                    {
                        sonuc = sayi1 * sayi2;
                        break;

                    }
                    case 4:
                    {
                        sonuc = sayi1 / sayi2;
                        break ;

                    }
                    default:
                    Console.WriteLine("hatalı giriş yaptınız");
                    goto secim;



            }
            Console.WriteLine("işlem sonucu"+sonuc );
            Console.ReadKey();
        }
    }
}
