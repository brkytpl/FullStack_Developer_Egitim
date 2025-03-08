using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmenler ogretmenler = new Ogretmenler();
            ogretmenler.verial();
            Ogrenciler ogrenciler = new Ogrenciler();
            ogrenciler.okuladi = "nfks";
        }
    }
}
