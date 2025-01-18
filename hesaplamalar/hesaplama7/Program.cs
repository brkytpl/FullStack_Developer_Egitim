using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eğitimi ortaöğretim 3000 diğer tüm durumlar için 5000
            Console.WriteLine("Eğitim durumunuz ortaöğretim için 1 \nLise için 2\nönlisans için 3\nlisans için 4\nyüksek lisans için 5");
            string secim = Console.ReadLine();
            //switch (secim) 
            //{ 
            //case "1":
            //        Console.WriteLine("3000 tl");
            //        break;
            //        case "2":
            //        case "3":
            //        case "4":
            //        case "5":
            //        Console.WriteLine("5000 tl");
            //        break;
            //        default:
            //        Console.WriteLine("hatalı giriş");
            //        break;
            //}
            switch (secim)
            {
                case "1":
                    Console.WriteLine("3000 tl");
                    break;
                case string x when (x == "2" || x == "3" || x=="4"|| x=="5"):
                    Console.WriteLine("5000 tl");
                    break;
                    default:
                    Console.WriteLine("hatalı giriş");
                    break;
            }
            Console.ReadLine();
        }
    }
}
