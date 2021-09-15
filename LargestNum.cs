using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class LargestNum
    {
        public static void Large()
        {
            Random n1 = new Random();
          int num1 = n1.Next(1000);
            Console.WriteLine(+num1+" 1st is number");

            Random n2 = new Random();
           int num2 = n2.Next(1000);
            Console.WriteLine(+num2+" 2nd is number");

            Random n3 = new Random();
           int num3 = n3.Next(1000);
            Console.WriteLine(+num3+" 3rd is number");

            if (num1 > num2 && num2 > num3)
                Console.WriteLine(+num1+" is Greater number");
            else if (num2 > num3 && num3 > num1) 
            Console.WriteLine(+num2 + " is Greater number");
            else
                Console.WriteLine(+num3+" is Greater number");

        }
    }
}
