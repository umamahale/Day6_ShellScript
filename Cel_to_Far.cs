using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Cel_to_Far
    {
        static float Cel_To_Fah(float n)
        {
            return ((n * 9.0f / 5.0f) + 32.0f);
        }

        // Driver code
        public static void Main()
        {
            float n = 20.0f;
            Console.Write(Cel_To_Fah(n));
        }
    }
}

