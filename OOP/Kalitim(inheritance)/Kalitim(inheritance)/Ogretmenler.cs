using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_
{
    internal class Ogretmenler:Okul//okul clasından öğretmenlere miras bırakıldı
    {
        public string ogretmenad;

        public void Ogretmenverial()
        {
            base.verial();
            Console.WriteLine("öğretmenler için işlemler başladı");
        }
    }
}
