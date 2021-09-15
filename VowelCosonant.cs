using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignments
{
    class VowelCosonant
    {
        public static void Alphabet()
        {
            //string a;
            //string e;
            //string i;
            //string o;
            //string u;
            Console.WriteLine("Enter any aplhabet a-z: ");
            string Alpha = Console.ReadLine();
          
            if (Alpha == "a" || Alpha == "e" || Alpha == "i" || Alpha == "o" || Alpha == "u")
                Console.WriteLine(" Aplhabet" + Alpha + " is Vowel");
            else
                Console.WriteLine(" Aplhabet"+Alpha +" is Consonant");

        }

    }
}
