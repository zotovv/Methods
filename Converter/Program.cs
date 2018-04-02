using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static double Conv(double currency, double exchange)
        {
            return currency * exchange;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму для конвертации: ");
            double currency = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите курс валюты для конвертации: ");
            double exchange = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Перевод суммы денег {0} по курсу {1} в сумму {2}", currency, exchange, Conv(currency, exchange));

            //Delay
            Console.ReadKey();
        }
    }
}
