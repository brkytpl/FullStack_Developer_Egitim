using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 den 100 e kadar olan sayılardan 3 e tam bölünenlerini ekranda göstericek ve toplamda
            //kaç adet 3 e bölünen sayı olduğunu gösterecek uygulama


            int bölünen = 0;
            for (int i = 1;i<=100;i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                    bölünen++;
                }
            }
            Console.WriteLine("Tam bölünen sayı adeti: "+bölünen);
            Console.ReadKey();
        }
    }
} 
