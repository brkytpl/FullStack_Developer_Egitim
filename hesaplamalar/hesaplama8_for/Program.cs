using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama8_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.For -- dizi ve koleksiyon
            //2.While -- ado.net te database işlemlerinde
            //3.do while
            //4.foreach -- mvc , .net,core da listeleme işlemlerinde

            //soru: 1 den 10  a kadar olan sayıları yazdıran uygulama
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);   
            }
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 1; i--) 
            {
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 10; i += 2) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();  
        }
    }
}
