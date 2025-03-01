using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar2
{
    internal class Program
    {
        public static float Alanhesapla(float k_kenar, float u_kenar)
        {
            return k_kenar * u_kenar;
        }
        static void Main(string[] args)
        {
            // dikdörtgen alanı hesaplayan bir metotdla uygulama geliştirelim

            Console.WriteLine("Alan hesabı için kısa kenar ölçüsü girin");
            float kisakenar=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Alan hesabı için uzun kenar ölçüsü girin");
            float uzunkenar = Convert.ToSingle(Console.ReadLine());

            float sonuc=Alanhesapla(kisakenar, uzunkenar);
            Console.WriteLine("Alan sonucu "+sonuc);
            Console.ReadKey();

        }
    }
}
