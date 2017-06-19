using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Factorial.FactorialFunc(5);
            Console.WriteLine($"Factorial of 5 is : {result}");
            Console.ReadKey();

            float result2 = Factorial.Power(5, 4);
            Console.WriteLine($"Power of 5 to 4 is : {result2}");
            Console.ReadKey();

        }
    }
}
