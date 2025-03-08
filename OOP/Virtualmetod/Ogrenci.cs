using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualmetod
{
    internal class Ogrenci:Okul
    {
        public string no;

        public override void verial()
        {
            base.verial();
            Console.WriteLine("öğrenci no giriniz");
            no=Console.ReadLine();
        }
        public override void veriyaz()
        {
            base.veriyaz();
        }
    }
}
