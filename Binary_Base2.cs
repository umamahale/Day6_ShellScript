using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Binary_Base2
    {
        static void block(long x)
        {
            List<int> v = new List<int>();

            // Convert decimal number to
            // its binary equivalent
            Console.Write("Blocks for " + x + " : ");

            while (x > 0)
            {
                v.Add((int)x % 2);
                x = x / 2;
            }

            // Displaying the output when
            // the bit is '1' in binary
            // equivalent of number.
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == 1)
                {
                    Console.Write(i);

                    if (i != v.Count - 1)
                        Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        // Driver Code here
        public static void Main()
        {
            block(71307);
            block(1213);
            block(29);
            block(100);
        }
    }
}

