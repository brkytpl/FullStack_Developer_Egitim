using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulkayit_konsol_projesi_dizi
{
    internal class Veri_isleme : OgrenciVeri
    {
        public virtual void kayitekle()
        {
            Console.WriteLine("****KAYIT EKLEME****");
            Console.WriteLine("Ad: ");
            ad[sayac]=Console.ReadLine();
            Console.WriteLine("Soyad: ");
            soyad[sayac] = Console.ReadLine();
            
        }
        public virtual void kayitlarilistele()
        {
            for(int i=0;i<ad.Length;i++)
            {
                Console.WriteLine((i+1)+"Öğrenci");
                Console.Write("Ad:" + ad[i] + "" + "soyad: "+ soyad[i]);
            }
        }

        static public void Menusecim()
        {
            Console.WriteLine("Kayıt Ekleme için 1\nKayıt Silmek için 2\nListeleme için 3\nArama için 4\nÇıkış için 5 e basınız");
            byte cevap = Convert.ToByte(Console.ReadLine());
            Ogrenciler ogrenciler = new Ogrenciler();
            switch (cevap)
            {
                case 1:
                    ekrantemizle();
                    ogrenciler.kayitekle();
                    break;
                case 2:
                    break;
                case 3:
                    ogrenciler.kayitlarilistele();
                    break;
                case 4:
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

            }
        }
        static public void ekrantemizle()
        {
            Console.Clear();
        }
    }
}


        
