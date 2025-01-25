using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Muhtaç öğrencilere taban olarak 1000TL burs verilmektedir. Ancak öğrencinin okuduğu
            //okula göre bu paranın üzerine belirli miktarda ekleme yapılacaktır.Eğer ilkokul ise ekleme
            //yapılmayacak, ortaokul ise 200TL, lise ise 500TL, üniversite ise 1000TL eklenecektir.
            //Öğrencinin okuduğu okulun seçimine göre kaç tl burs alacağını gösteren uygulama. (bu
            //soruyu hem if hem switch ile çözelim)

            Console.WriteLine("Lütfen okulunuzu seçiniz, ilkokul için 1, Ortaokul için 2, Lise için 3, Üniversite için 4");
            int secim =Convert.ToInt32(Console.ReadLine());
            int burs = 1000;
            switch (secim)
            {
                case (1):
                    Console.WriteLine("Bursunuz {0} tldir.",burs);
                    break;
                case (2):
                    Console.WriteLine("Bursunuz {0} tldir.", burs + 200);
                    break;
                case (3):
                    Console.WriteLine("Bursunuz {0} tldir.", burs + 500);
                    break;
                case (4):
                    Console.WriteLine("Bursunuz {0} tldir.", burs + 1000);
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız");
                    break;
            }
            Console.ReadLine();

        }
    }
}
