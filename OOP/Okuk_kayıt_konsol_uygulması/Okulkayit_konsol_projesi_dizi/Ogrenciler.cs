using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulkayit_konsol_projesi_dizi
{
    internal class Ogrenciler:Veri_isleme
    {
        public override void kayitekle()
        {
            kayit:
            base.kayitekle();
            Console.WriteLine("Not: ");
            not[sayac]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yas: ");
            yas[sayac]=Convert.ToByte(Console.ReadLine());
            sayac++;
            Console.WriteLine("Kayıda devam etmek istiyormusunuz E/H");
            string cevap=Console.ReadLine();
            if (cevap.ToUpper() == "E")
            {
                ekrantemizle();
                goto kayit;
            }
            else 
            {
                ekrantemizle();
                Menusecim();
            }

        }
        public override void kayitlarilistele()
        {
            base.kayitlarilistele();
            for (int i = 0; i < ad.Length; i++) 
            {
                Console.WriteLine(" Yaş: " +yas[i]+" Notu: " + not[i]);
            }
        }



    }
}
