using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class HarmonicNum
    {
        public static void Harmonic()
        {
            float Harmonic =  1;
            int N;
            //taking value from user
                Console.WriteLine("Enter Harmonic Number N:");
            N=Convert.ToInt32(Console.ReadLine());
            
            //Harmonic number= 1 + 1/2 + 1/3 + ... + 1/N
            for (float H = 2; H <= N; H++)
            {
                Harmonic += (float)1 / H;

              
            }
                Console.WriteLine("Harmonic number of "+N +" =" + Harmonic);
           


        }
    }
}
