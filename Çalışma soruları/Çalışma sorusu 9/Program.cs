using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kare, üçgen ve dikdörtgenler için alan ve çevre hesabı yapan uygulama geliştirilecek.
            Kullanıcıya önce hangi şekil için işlem yapılacağı sorulacak. Sonra ona göre kenar
            ölçülerini girmesi istenecek.Yani örneğin üçgen seçtiyse 3 kenarın ölçüsü kare seçtiyse
            bir kenar ölçüsü istenecek gibi.Sonrada hesaplama yapılıp alan ve çevre ölçüleri
            gösterilecek.*/

            Console.WriteLine("Alan hesabı yapmak istediğiniz şekli seçiniz");
            git:
            string secim=Console.ReadLine();
            switch (secim)
            {
                case "kare":
                    {
                        int alan;
                        Console.WriteLine("Karenin kaner uzunluğunu giriniz");
                        int kenar= Convert.ToInt32(Console.ReadLine());
                        alan = kenar * kenar;
                        Console.WriteLine("Karenin alanı= "+alan);
                    }
                break;
                case "dikdörtgen":
                    {
                        int alan;
                        Console.WriteLine("Dikdörtgenin kaner uzunluklarını giriniz");
                        int kenar1 = Convert.ToInt32(Console.ReadLine());
                        int kenar2 = Convert.ToInt32(Console.ReadLine());
                        alan=kenar1 * kenar2;
                        Console.WriteLine("Dikdörtgenin alanı= " + alan);
                    }
                    break;
                case "üçgen":
                    {
                        double alan;
                        Console.WriteLine("Üçgenin taban ve yüksekliğini giriniz");
                        double yükseklik= Convert.ToDouble(Console.ReadLine());
                        double taban= Convert.ToDouble(Console.ReadLine());
                        alan = (taban * yükseklik) / 2;
                        Console.WriteLine("Üçgenin alanı= " + alan);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Hatalı seçim yaptınız");
                        goto git;
                    }
                }
            Console.ReadKey();
        }
    }
}
