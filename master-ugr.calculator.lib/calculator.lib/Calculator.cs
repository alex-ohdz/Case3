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
                return number2 == 0 ? double.NaN : number1 / number2;
            }

            public static bool IsPrime(int number)
                {
                    return number == 2;
                }
            public static double SqrtNumber(double number)
            {
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate the square root of a negative number.");
                }
                return Math.Sqrt(number);
            }
    }
}
