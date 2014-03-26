using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;

            int guess, low = 0, high = 100;    
          

            while (true)
            {
                guess = (high + low) / 2;
                Console.WriteLine("Is your guess {0}? h,l,e ", guess);

                input = Console.ReadLine();

                if (input == "h")
                {
                    low = guess + 1;
                }
                else if (input == "l")
                {
                    high = guess - 1;
                }


                 if (input == "e")
                {

                    Console.WriteLine("I win!!!");

                        System.Environment.Exit(-1);
                }
                        
            }

        }

    }
}