using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj swoją wagę w kilogramach: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach: ");
            b = double.Parse(Console.ReadLine());
            c = a / (b * b);
            Console.WriteLine("Twoje BMI wynosi " + c);
            Console.ReadKey();
        }
    }
}
