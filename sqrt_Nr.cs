using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class sqrt_Nr
    {
        static double squareRoot(double n, double l)
        {
            // Assuming the sqrt of n as n only
            double x = n;

            // The closed guess will be stored in the root
            double root;

            // To count the number of iterations
            int count = 0;

            while (true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (n / x));

                // Check for closeness
                if (Math.Abs(root - x) < l)
                    break;

                // Update root
                x = root;
            }

            return root;
        }

        // Driver code
        public static void Main()
        {
            double n = 327;
            double l = 0.00001;

            Console.WriteLine(squareRoot(n, l));
        }
    }
}

