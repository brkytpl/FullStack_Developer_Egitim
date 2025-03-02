using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Ogrenciler
    {
        //Kapsülleme(encapsulation):Private olan alanların kullanıma kontrollü açılmasıdır.
        string ad;
        private string soyad;
        public string tc;

        public string Ad // Private olan ad alanının kapsüllenmesi(kullanıma açılması)
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad 
        {
            get { return soyad; }
            set {
                  if(value.Length>=5)
                {  
                    soyad = value; 
                }
                }
        }
    }
}
