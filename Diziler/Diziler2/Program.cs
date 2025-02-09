using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30 };
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****************************************");

            ArrayList sayilar2 = new ArrayList();
            sayilar2.Add(100);
            sayilar2.Add(200);
            sayilar2.Add(300);

            foreach (int i in sayilar2)
            {
                Console.WriteLine(i);
            }
            ArrayList Ogrenci1 = new ArrayList();
            Ogrenci1.Add("Ali");
            Ogrenci1.Add(12);
            Ogrenci1.Add(100);
            Ogrenci1.Add('A');
            Console.WriteLine("****************************************");
            foreach (var i  in Ogrenci1)
            {
                Console.WriteLine(i);
            }

            int[] rakamlar = { 9, 2, 5 };
            Array.Sort(rakamlar);
            //Array.Clear(rakamlar, 1, 2);
            Console.WriteLine(Array.IndexOf(rakamlar, 15));
            if (Array.IndexOf(rakamlar, 5) == -1)
            {
                Console.WriteLine("sayı yok");

            }
            else 
            {
                Console.WriteLine("sayısının inidisi: " + Array.IndexOf(rakamlar, 5));
            
            }
            //Console.WriteLine(rakamlar[0]);
        }
    }
}
