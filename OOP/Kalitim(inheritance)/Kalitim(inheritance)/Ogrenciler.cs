using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_
{
    internal class Ogrenciler:Ogretmenler
    {
        public string ad;
        public void OgrenciVerial()
        {
            base.verial();
            Console.WriteLine("öğrenci kaydı için işlemler başladı");
        }
    }
}
