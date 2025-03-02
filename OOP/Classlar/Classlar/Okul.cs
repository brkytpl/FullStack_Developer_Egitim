using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Okul//static classlara nesne üretmeden direk ulaşılır
                                // class static olursa tüm alanlar ve metotlarda static olmak zorundadır
    {
        static public string adres;
        public string personelsayisi;

        static public void Verial()
        {
            Console.WriteLine("adres giriniz");
            string adres=Console.ReadLine();
        }
    }
}
