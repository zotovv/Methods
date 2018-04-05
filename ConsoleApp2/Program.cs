using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Calculate(ref double x, ref double y, ref double z)
        {
            x /= 5;
            y /= 5;
            z /= 5;            
        }


    static void Main(string[] args)
        {
            double operand1 = 15, operand2 = 14, operand3 = 13;
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3 );

            Calculate(ref operand1, ref operand2, ref operand3);
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3);

            Console.ReadKey();
        }
    }
}
