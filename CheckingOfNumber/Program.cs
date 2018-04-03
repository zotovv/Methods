using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingOfNumber
{
    class Program
    {
        static void CheckNegative(int number)
        {
            number = number >> 31;
            if (number == -1)
            {
                Console.WriteLine("Число отрицательное.");
            }
            else
            {
                Console.WriteLine("Число положительное.");
            }
        }

        static void CheckSimple(int number) // Простое число имеет только 2 делителя, дающих нулевой остаток (единица и само проверяемое число).
        {
            int dividers = 0; // Количество делителей

            for (int i = 1; i <= number; i++) // Перебираем все делители от 1 до проверяемого числа.
            {
                if (number % i == 0)
                {
                    dividers++; // Если остаток от деления на данный делитель равен нулю, увеличиваем общее кол-во таких делителей.

                }
            }

            if (dividers == 2) // Число простое - при наличии только двух делителей, дающих в остатке ноль.
            {
                Console.WriteLine("Число простое.");
            }
            else
            {
                Console.WriteLine("Число не является простым.");
            }           
        }

        static void CheckDivider(int number)
        {
            if ((number % 2) == 0 && (number % 5) == 0 && (number % 3) == 0 && (number % 6) == 0 && (number % 9) == 0)
            {
                Console.WriteLine("Число делится без остатка на 2, 3, 5, 6, 9");
            }
            else
            {
                Console.WriteLine("Число  не делится без остатка на 2, 3, 5, 6, 9");
            }
        }



        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки: ");
            int number = Convert.ToInt32(Console.ReadLine());

            CheckNegative(number);

            CheckSimple(number);

            CheckDivider(number);

            //Delay
            Console.ReadKey();

        }
    }
}
    

