﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }


        static void Main(string[] args)
        {
            int operand1 = 3;
            Console.WriteLine(Factorial(operand1));

            Console.ReadKey();
        }
    }
}
