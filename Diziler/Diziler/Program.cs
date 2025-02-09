using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler
            int[] sayilar = { 1, 2, 3, 4, 5, };
            int[] sayilar2 = new int[3];
            sayilar2[0] = 1;
            //çok boyutlu düzenli diziler
            int[,] notlar = { {101,80}, {102,90}, {103,70} };
            Console.WriteLine("öğrenci no: "+ notlar[0,0]);
            Console.WriteLine("not: " + notlar[0, 1]);
            //3 boyutlu dizi
            int[,,] ögrenciler = { { { 101 },{ 12 },{ 100 } },
                { { 102 },{ 11 },{ 80 } },
                 { { 103 },{ 13 },{ 70 } },
                 { { 104 },{ 14 },{ 90 } } };
            //2 boyutlu dizi
            string[,] isimliste = { { "ali", "100" }, { "veli", "90" }, { "ömer", "90" } };
            Console.WriteLine(isimliste[0,1]);

            isimliste[0, 1] = "70";
            Console.WriteLine(isimliste[0, 1]+ isimliste[0,0]);

            //Düzensiz dizi. Elemanları dizilerden oluşan dizi
            int[][] sinif=new int[3][];
            sinif[0]=new int[] { 102, 103, 104 };
            sinif[1] = new int[] { 12, 11, 13 };
            sinif[2] = new int[] { 80, 70, 90 };

            Console.WriteLine(sinif[0][1]);

            //Koleksiyon
            ArrayList okul=new ArrayList();
            okul.Add("Ali");
            okul.Add(90);
            okul.Add('A');
            ArrayList notlar2 = new ArrayList();
            notlar2.Add(90);
            notlar2.Add(80);
            notlar2.Add(70);
            notlar2.Add(50);
            notlar2.Add(200);
            notlar2.Sort();// koleksiyonu küçükten büyüğe sıralar
            notlar2.Reverse();//sayılarını tersler
            notlar2.Remove(0);//indis numarsına göre o indisi siler


            Console.WriteLine(notlar2[0]);
            Console.WriteLine(notlar2[4]);
            notlar2[4] = 100;
            Console.WriteLine(notlar2[4]);
            Console.ReadLine();

        }
    }
}
