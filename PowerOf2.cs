using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class PowerOf2
    {
        public static void Power()
        {
           double n;
           double N;
            Console.WriteLine("Enter number to find Power of 2*N:");
            N = Convert.ToInt32(Console.ReadLine());

            // power of 2 only till 0<=N<31 as overflows int
            
            n =  Math.Pow(N, 2);
            Console.WriteLine("Power of 2^N=" + n);
        }
    }
}
