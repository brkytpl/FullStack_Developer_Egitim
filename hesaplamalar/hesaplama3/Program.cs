using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği ad ve şifre doğru ise hoşgeldiniz değilse hatalı giriş gösteren uygulama
            string ad = "Berkay";
            string sifre = "55b";
            go:
            Console.Write("kullanıcı adını giriniz");
            string kullaniciAd=Console.ReadLine();
            Console.Write("kullanıcı şifre giriniz");
            string kullaniciSifre=Console.ReadLine();

            if (ad == kullaniciAd && sifre == kullaniciSifre)
            {
                Console.WriteLine("hoşgeldiniz");

            }
            else
            {
                Console.WriteLine("hatalı giriş");
                goto go;
            }
            Console.ReadKey(); 
        }
    }
}
