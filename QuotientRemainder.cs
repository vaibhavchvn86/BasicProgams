using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class QuotientRemainder
    {
        public static void Num1()
        {
            
            int remainder;
            Console.WriteLine("Enter Dividend/Numerator: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor/Denominator: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = Math.DivRem(dividend, divisor, out remainder);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
