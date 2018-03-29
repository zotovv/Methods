using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Числа {0}, {1}, {2} среднее арифметическое {3}", a, b, c, (a + b + c) / 3);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");

            string operand1 = Console.ReadLine();
            int multiplier1 = Int32.Parse(operand1);

            Console.WriteLine("Введите второе число: ");

            string operand2 = Console.ReadLine();
            int multiplier2 = Int32.Parse(operand2);

            Console.WriteLine("Введите третье число: ");

            string operand3 = Console.ReadLine();
            int multiplier3 = Int32.Parse(operand3);

            Calculate(multiplier1, multiplier2, multiplier3);


            //Delay
            Console.ReadKey();
        }
    }
}
