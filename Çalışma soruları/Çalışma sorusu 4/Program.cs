using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız.Eğer
            // 150’den küçükse kWh’i 10 kuruş, eğer 150 ile 300 arasında ise 20 kuruş, 300
            //üzeri ise 40 kuruş olarak hesaplanmaktadır.Kişinin yaptığı tüketime göre faturasının kaç
            //TL olacağını hesaplayıp ekrana yazan program.

            Console.WriteLine("Tükettiğiniz kWh değerini giriniz");
            double harcanan=Convert.ToDouble(Console.ReadLine());
            if (harcanan < 150)
            {
                Console.WriteLine("Fatura tutarı: {0} TL", harcanan * 0.10);
            }
            else if (harcanan >= 150 && harcanan <= 300)
            {
                Console.WriteLine("Fatura tutarı: {0} TL", harcanan * 0.20);
            }
            else
            {
                Console.WriteLine("Fatura tutarı: {0} TL", harcanan * 0.40);
            }
            Console.ReadKey();
        }
    }
}
