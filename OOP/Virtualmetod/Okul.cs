using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualmetod
{
    internal class Okul
    {
        public string ad;
        public virtual void verial()
        {
            Console.WriteLine("ad giriniz");
            ad=Console.ReadLine();

        }
        public virtual void veriyaz()
        {
            Console.WriteLine(ad);
        }
    }
}
