using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualmetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Okul okul = new Okul();
            okul.verial();
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.verial();
        }
    }
}
