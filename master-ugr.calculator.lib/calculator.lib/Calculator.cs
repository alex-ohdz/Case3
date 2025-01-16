using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.lib
{
    public static class Calculator
    {
            public static int Add(int number1, int number2)
            {
                return number1 + number2;
            }
            public static int Subtract(int number1, int number2)
            {
                return number1 - number2;
            }
            public static int Multiply(int number1, int number2)
            {
                return number1 * number2;
            }
            public static double Divide(double number1, double number2)
            {
                return ((double)number1) / ((double)number2);
            }
            public static bool IsPrime(int number)
            {
                return number == 2;
            }
    }
}
