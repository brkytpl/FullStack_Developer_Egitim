using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace yapicimetod
{
    internal class Ogrenciler
    {
        public string ad;
        public string soyad;

        public Ogrenciler() 
        {
            Console.WriteLine("yapıcı metodumuz çalıştı");
        }
        ~Ogrenciler()
        {
            Console.WriteLine("yıkıcı metod çalıştı");
        }
    }
}
