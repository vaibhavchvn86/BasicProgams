using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class FlipCoin
    {
        public static void Flip()
        {
            int flipcount = 10;
            double Heads = 0;
            double Tails = 0;


            for (int i = 1; i <= flipcount; i++)
            {
                Random random = new Random();
                int flip = random.Next(0, 2);
                if (flip < 0.5)
                {
                    Console.WriteLine("Tails");
                    Tails += 1;
                }
                else
                {
                    Console.WriteLine("Heads");
                    Heads += 1;
                }
                Console.WriteLine(+(Heads / flipcount) * 100 + "%");
                Console.WriteLine(+(Tails / flipcount) * 100 + "%");
            }
        }
    }
}
