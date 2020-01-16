using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;
            bool wynik;
            wynik = !((x == 1 || y != 5) && z < 1);            // && has greater priority than ||
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
