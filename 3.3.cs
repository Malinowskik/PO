using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź 1 liczbe");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź 2 liczbe");
            double l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz działanie: +, -, /, *");
            string s = (Console.ReadLine());
            if (s == "+")
                Console.WriteLine("=", l1 + l2);
            else if (s == "-")
                Console.WriteLine("=", l1 - l2);
            else if (s == "*")
                Console.WriteLine("=", l1 * l2);
            else if (s == "/")
                Console.WriteLine("=", l1 / l2);
            else
                Console.WriteLine("Błędne dane");

            Console.ReadKey();
        }
    }
}