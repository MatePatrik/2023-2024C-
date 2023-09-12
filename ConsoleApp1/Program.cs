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
            Console.WriteLine("Két szám összeadása! ");
            Console.WriteLine("Adj meg 1 számot: ");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg 1 másik számot: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("A két szám összege: " + (a+b));
            Console.ReadKey();
        }
    }
}
