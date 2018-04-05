using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
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
            Console.WriteLine("Введите число: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Факториал числа {0} равен {1}", operand1, Factorial(operand1));

            Console.ReadKey();
        }
    }
}
