using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapicimetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler ogr1 = new Ogrenciler();
            ogr1.ad = "berkay";
            Console.WriteLine("adınız: "+ogr1.ad);
            //Console.ReadKey(); 
        }
    }
}
