using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı klavyeden 20 sayısını girene kadar sayı isteyen ve sayıların teklerinin toplamını çiftlerin adedini yazdıran uygulama
            int adet = 0;
            int toplam=0;
            while (true)
            {
                Console.WriteLine("sayı giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());
                if (sayi == 20)
                {
                    break;
                }
                else 
                {
                    if (sayi % 2 == 0)
                    {
                        adet++;
                    }
                    else 
                    {
                        toplam += sayi;
                    }
                }
            }
            Console.WriteLine("teklerin toplamı= "+toplam);
            Console.WriteLine("çiftlerin adedi= "+adet);
            Console.ReadLine();
        }
    }
}
