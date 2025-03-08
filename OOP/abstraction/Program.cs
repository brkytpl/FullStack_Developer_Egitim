using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abstraction (soyutlamak)=Nesne yönelimli programlamada ayırma ayrıntıları tanımlamaktan ziyade sınıfler ve yöntemler için temel görevleri tanımlamak anlamına gelir.
            //( bir kitabın içindekiler sayfasını oluşturmak gibi)
            //Abstraction= Abstrac(soyut) class kullanılarak nesne üretirken bir şablon kullanmak isteyişimiz olarakta yorumlayabiliriz.
            // Not: abstrac metod yapacaksak bulunduğu class da abstrac olmak zorunda ve kalıtım alan alt classlar bu metodu override etmek zorunda
            //Ana class olmak zorundadır.
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.verial();

        }
    }
}
