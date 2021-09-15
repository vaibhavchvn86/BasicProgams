using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class EvenOdd
    {
        public static void Num()
        {
            int N;
            Console.WriteLine("Enter Number N: ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0)
                Console.WriteLine(+N+" is Even number");
            else
                Console.WriteLine(+N+" is Odd number");

        }
    }
}
