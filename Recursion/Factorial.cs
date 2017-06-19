using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Factorial
    {
        public static int FactorialFunc(int factorialNum)
        {
            if (factorialNum == 1)
                return 1;
            return factorialNum * FactorialFunc(factorialNum - 1);

            // Factorial(5) = 5 * Factorial(4)
            // Factorial(4) = 4 * Factorial(3)
            // Factorial(3) = 4 * Factorial(2)
            // Factorial(2) = 4 * Factorial(1)
            // Factorial(1) = 1;
        }

        public static float Power(float num, int powerOf)
        {
            // Exit condition
            if (powerOf == 1)
                return num;
            return num * Power(num, powerOf - 1);

        }
    }
}
