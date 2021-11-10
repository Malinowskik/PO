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
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź 2 liczbe");
            int liczba2 = int.Parse(Console.ReadLine());
            if (liczba % liczba2 == 0)
                    Console.WriteLine("{0} jest podzielna przez {1}", liczba, liczba2);
                else 
                    Console.WriteLine("{0} nie jest podzielna przez {1}", liczba, liczba2);
            Console.ReadKey();
        }
    }
}
