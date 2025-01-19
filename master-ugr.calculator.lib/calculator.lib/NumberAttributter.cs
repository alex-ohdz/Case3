using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.lib
{
    public class NumberAttributter
    {
        public static bool IsPrime(int number)
        {            
            // We handle numbers less than 2 and the small prime numbers 2, 3, and 5 directly
            if (number < 2) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            // We check divisibility by 2, 3, and 5 early to quickly eliminate non-prime numbers
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;
            // We use a loop starting from 7, incrementing by 2 to skip even numbers,
            // and check up to the square root of the number
            int limit = (int)Math.Sqrt(number);
            for (int i = 7; i <= limit; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

    }
}
