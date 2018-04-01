using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);           
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }

        static void Divide(int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции: ");
            string sign = Console.ReadLine();

            switch(sign)
            {
                case "+":
                    Add(operand1, operand2);
                    break;
                case "-":
                    Subtract(operand1, operand2);
                    break;
                case "*":
                    Multiply(operand1, operand2);
                    break;
                case "/":
                    Divide(operand1, operand2);
                    break;
                default:
                    Console.WriteLine("Вы ввели не знак арифметической операции!");
                    break;
            }

            //Delay
            Console.ReadKey();

        }
    }
}
