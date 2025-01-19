using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rastgele 20 sayıdan çift olanların toplamını gösteren uygulama
            Random rand = new Random();
            int toplam = 0;
            for (int i = 0; i <= 20; i++)
            {
               
                int sayi=rand.Next(1,100);
                Console.WriteLine(sayi);
                if (sayi %2== 0)
                {
                    toplam += sayi;                       
                }
                
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
