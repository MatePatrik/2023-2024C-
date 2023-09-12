using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Két szám összeadása! ");
            a = szamotker("Adj meg 1 számot: ");
            b = szamotker("Adj meg 1 másik számot: ");
            Console.Write("A két szám összege: " + (a+b));
            Console.ReadKey();
        }

        private static int szamotker(string szo)
        {
            int bekertszam;
            Console.Write(szo);
            bekertszam = int.Parse(Console.ReadLine());
            return bekertszam;
        }
    }
}
