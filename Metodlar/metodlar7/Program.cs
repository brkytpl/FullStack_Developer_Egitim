using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar7
{
    internal class Program
    {
        public static void ortalama(float not1, float not2)
        {
            Console.WriteLine("Ortalama: "+((not1+not2)/2));
        }
        public static void ortalama(float not1, float not2,float sözlü)
        {
            Console.WriteLine("Ortalama: " + ((not1 + not2+sözlü) / 3));
        }
        public static void ortalama(float not1, float not2, float sözlü, float uygulama)
        {
            Console.WriteLine("Ortalama: " + ((not1 + not2 + sözlü + uygulama) / 4));
        }
        static void Main(string[] args)
        {
            //ilkokul öğrencisi için iki notun ortalaması ortaokul için iki not ve sözlü ortalaması lise için iki not sözlü ve uygulama ortalaması yapan metod yapalım
            Console.WriteLine("1- ilkokul\n2- Ortaokul\n3- Lise");
            byte secim= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Birinci sınav notu:");
            float not1= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("İkinci sınav notu:");
            float not2 = Convert.ToSingle(Console.ReadLine());
            float sözlü,uygulama;
            switch (secim)
            {
                case 1:
                    {
                        ortalama(not1 , not2);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("sözlü notu: ");
                        sözlü=Convert.ToSingle(Console.ReadLine());
                        ortalama(not1, not2,sözlü);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("sözlü notu: ");
                        sözlü = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("uygulama notu: ");
                        uygulama = Convert.ToSingle(Console.ReadLine());

                        ortalama(not1, not2, sözlü,uygulama);
                        break;
                    }
                default:
                    { Console.WriteLine("Hatalı giriş yaptınız");
                        break;
                    }
            }
            Console.ReadLine();

        }
    }
}
