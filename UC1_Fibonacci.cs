using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class UC1_Fibonacci
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        // driver code

        public static void Main(string[] args)
        {
            int n = 20;
            Console.Write(Fib(n));
        }



    }
    }



