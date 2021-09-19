using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Prime_Numb
    {
        static bool IsPrime(int n)
        {
            // Corner case
            if (n <= 1)
                return false;

            // Check from 2 to n-1
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        // Driver Code
        private static void Main()
        {
            if (IsPrime(11))
                Console.Write(" true");

            else
                Console.Write(" false");
        }
    }
}

