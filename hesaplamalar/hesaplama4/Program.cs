using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if yapısında bakılması gereken şart birden fazla olursa
            //öğrenci notu 50 den küçükse kaldı, 50 den büyükse geçti, not 100 e eşitse onur belgesi aldı
            git:
            Console.WriteLine("notunuzu giriniz");
            byte not=Convert.ToByte(Console.ReadLine());
            if (not < 0 || not > 100)

            {
                Console.WriteLine("hatalı giriş");
                goto git;
            }
            else if (not == 100)
            {
                Console.WriteLine("onur belgesi");

            }
            else if (not < 50)
            {
                Console.WriteLine("kaldı");
            }
            else if (not >= 50)
            {
                Console.WriteLine("geçti");
            }
                       
            
        }
    }
}
