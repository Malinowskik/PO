﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine());
            F = 9.0 / 5 * C + 32;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}