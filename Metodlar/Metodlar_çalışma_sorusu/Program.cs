using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_çalışma_sorusu
{
    internal class Program
    {
        public static void Merhaba(int x)
        {
            x=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Merhaba");
            }
        }
        static void Main(string[] args)
        {
            Merhaba(3);
            
        }
    }
}
