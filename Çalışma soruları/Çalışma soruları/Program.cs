using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_soruları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sıcaklık değerini giriniz.");
            int sicaklik=Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Sıcaklık:"+sicaklik);
            if (sicaklik <= 0)
            {
                Console.WriteLine("Madde katıdır.");
            }
            else if ((sicaklik > 0) && (sicaklik < 100))
            {
                Console.WriteLine("Madde sıvıdır.");
            }
            else
            {
                Console.WriteLine("Madde gazdır");
            }
            Console.ReadKey();


        }
    }
}
