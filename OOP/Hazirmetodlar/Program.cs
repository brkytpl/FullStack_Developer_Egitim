using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazirmetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matematiksel fonksiyonlar(metodlar)
            int x = 50;
            int y = 60;
            int z = -45;
            float t = -10.5f;
            float j =11.7895f;
            Console.WriteLine(Math.Abs(z));
            Console.WriteLine(Math.Abs(t));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Pow(x,2));
            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Round(t));
            Console.WriteLine(Math.Floor(j));
            Console.WriteLine(Math.Ceiling(j));

            //string metodlar
            string ad = "berkay";
            string soyad = "topal";
            Console.WriteLine(ad.ToUpper());
            Console.WriteLine(ad.Concat(soyad));
            Console.WriteLine(ad.IndexOf('a'));
            Console.WriteLine(ad.Split(' '));

            //tarih ve saat fonksiyonlar
            DateTime suan = DateTime.Now;
            Console.WriteLine(suan);
            DateTime bugün = DateTime.Today;
            Console.WriteLine(bugün);
            Console.WriteLine(bugün.AddYears(3));
            Console.WriteLine(bugün.Year);
        }
    }
}
