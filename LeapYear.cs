using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class LeapYear
    {
        public static void Leapyr()
        {
            double Year;

            Console.WriteLine("Enter Year In YYYY Format: ");
            Year = Convert.ToDouble(Console.ReadLine());
            if ((Year % 100) != 0 && (Year % 4) == 0)
                Console.WriteLine("This is a Leap Year");
            else
                Console.WriteLine("This is not a Leap Year");

        }
    }
}
