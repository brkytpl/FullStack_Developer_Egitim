using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_2_if
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

            Console.WriteLine("Okul seçimini yapınız.");
            string secim = Console.ReadLine();
            int burs = 1000;
            if (secim == "ilkokul")
            {
                Console.WriteLine("Bursunuz {0} tldir.", burs);
            }
            else if (secim == "ortaokul")
            {
                Console.WriteLine("Bursunuz {0} tldir.", burs + 200);
            }
            else if (secim == "Lise")
            {
                Console.WriteLine("Bursunuz {0} tldir.", burs + 500);
            }
            else if (secim == "Üniversite")
            {
                Console.WriteLine("Bursunuz {0} tldir.", burs + 1000);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
            Console.ReadKey();
        }
    }
}
