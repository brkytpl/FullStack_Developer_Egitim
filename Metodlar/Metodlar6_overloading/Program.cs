using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar6_overloading
{
    internal class Program
    {
        public static void topla(int x,int y)
        {
            Console.WriteLine("Sonuç: "+(x+y));

        }
        public static void topla(int x,int y,int z)
        {
            Console.WriteLine("Sonuç: " + (x + y+z));
        }
        public static void topla(float x, float y)
        {
            Console.WriteLine("Sonuç: " + (x + y+30));
        }
        static void Main(string[] args)
        {
            //metod overloading metodun aşırı yüklenmesi
            //metod isimleri aynı fakat parametleri farklı metod oluşturmak
            topla(20, 50);
            topla(10,20,5);
            topla(10.2f, 10.5f);
            topla(5.6f, 20);
            Console.ReadLine();
        }
    }
}
