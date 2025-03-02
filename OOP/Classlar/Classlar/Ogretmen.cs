using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Ogretmen
    {
        public string ad; // field(alan)
        public string brans;
        public float maas;

        public void BilgiAl()
        {
            Console.WriteLine("Ad giriniz");
            ad = Console.ReadLine();
        }
    }
}
