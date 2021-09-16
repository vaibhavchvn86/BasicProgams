using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class Factor
    {
       public static void fact()
        {
            double N;
            int i;
            Console.WriteLine("Enter Number N to find its prime factors");
            N = Convert.ToInt32(Console.ReadLine());
            while (N % 2 == 0)
            {
                N /= 2;
                Console.WriteLine(+2);
                break;
            }
            for ( i = 3; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    N /= i;
                    Console.WriteLine(+i);
                }
                break;
            }
            if (N > 2)
            {
                Console.WriteLine(+N);
            }           
        }
    }
}
