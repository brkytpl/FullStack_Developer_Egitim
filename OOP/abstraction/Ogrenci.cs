using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Ogrenci:Okul
    {
        public override void verial()
        {
            Console.WriteLine("Öğrenci class veri metodu çalıştı");
        }
        public override void veriyaz()
        {
            throw new NotImplementedException();
        }
    }
}
