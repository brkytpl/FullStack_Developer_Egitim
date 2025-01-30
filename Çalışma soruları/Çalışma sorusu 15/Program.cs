using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının ulaşım türünü YURTDIŞI ve YURTİÇİ şeklinde seçimini yaptıktan sonra bilet
fiyatı ve alacağı bilet adedini kullanıcıdan isteyelim giriş yapsın. Eğer seçimi
A. YURTDIŞI ise karşısına AVRUPA ASYA AFRİKA seçim seçenekleri gelsin ve
seçim yapsın. ( bu seçimde kullanıcıya Avrupa için A, Asya için B, Afrika için C’ye
basın şeklinde cevapları karakter olarak yazmalarını sağlayın). Bu ekrandaki
seçimine görede aşağıdaki işlemleri yaptıralım
• A seçimi yaptıysa bilet*adet tutarının %27 kadarı zam yap tutarı yazdır
• B seçimim için bilet*adet tutarının %17 kadarı zam yap tutarı yazdır
• C seçimi için bilet*adet tutarının %7 kadarı zam yap tutarı yazdır
B. Eğer seçimi YURTİÇİ ise uçuş gününü sor
• Hafta içi günler için bilet*adet tutarının %27 kadarı indirim yap tutarı
yazdır
• Hafta sonu günler için bilet*adet tutarının %7 kadarı indirim yap tutarı
yazdır*/

            yurt:
            Console.WriteLine("Aldığınız ürünün Yurt içi veya Yurt dışı seçimini yapınız");
            string secim = Console.ReadLine();
            Console.WriteLine("Fiyat Giriniz: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adet Giriniz: ");
            double adet = Convert.ToDouble(Console.ReadLine());
            double tutar;
            if (secim == "Yurtdışı")
            {
                Console.WriteLine("Kıta seçiminizi yapınız Avrupa için A, Asya için B, Afrika için C");
            git:
                char kıta = Convert.ToChar((Console.ReadLine()));
                switch (kıta)
                {
                    case 'A':
                        {
                            tutar = fiyat * adet * 1.27;
                            Console.WriteLine("Toplam tutar: " + tutar);
                            break;
                        }
                    case 'B':
                        {
                            tutar = fiyat * adet * 1.17;
                            Console.WriteLine("Toplam tutar: " + tutar);
                            break;
                        }
                    case 'C':
                        {
                            tutar = fiyat * adet * 1.07;
                            Console.WriteLine("Toplam tutar: " + tutar);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Hatalı seçim yaptınız");
                            goto git;
                        }
                }

            }
            else if (secim == "Yurtiçi")
            {
            sec:
                Console.WriteLine("Haftaiçi veya Haftasonu seçiminizi yapınız");
                string gün = Console.ReadLine();
                switch (gün)
                {
                    case "Haftaiçi":
                        {
                            tutar = fiyat * adet * 0.73;
                            Console.WriteLine("Toplam tutar: " + tutar);
                            break;
                        }
                    case "Haftasonu":
                        {
                            tutar = fiyat * adet * 0.93;
                            Console.WriteLine("Toplam tutar: " + tutar);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Yanlış seçim yaptınız");
                            goto sec;
                        }
                }

            }
            else
            {
                Console.WriteLine("Hatalı seçtiniz");
                goto yurt;
            }
        }
    }
}
