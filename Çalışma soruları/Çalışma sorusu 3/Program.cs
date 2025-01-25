using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_sorusu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir satıcı sattığı mallardan belirli oranda komisyon almaktadır. 200TL’ye kadar olan
            //satışlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır. Buna göre
            //klavyeden girilen 3 satış miktarından satıcının alacağı komisyonları ve toplam komisyonu
            //ekrana yazan program.


            double toplam = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i+".Satış tutarını giriniz");
                Double satıs = Convert.ToDouble(Console.ReadLine());
                double komisyon;
                if (satıs < 200)
                {
                    komisyon = ((satıs / 100) * 3);
                    Console.WriteLine(i+".komisyon tutarı:" + komisyon);                 
                }
                else
                {
                    komisyon = ((satıs / 100) * 2);
                    Console.WriteLine(i+".komisyon tutarı:" + komisyon);                   
                }
                toplam += komisyon;
                Console.WriteLine("Toplam değer:" + toplam);
            }           
            Console.ReadKey();
        }
           
        }
    }
