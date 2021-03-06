﻿using System;

namespace KEAOpgave5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int max = 101;

            // a way to keep showing intro/info since we initially set limit to 101
            while (max > 100)
            {
                Console.WriteLine("Hi! Were generating Pythagorean triplets.");
                Console.WriteLine("Please input a limit for the triplets of max 100:");
                Console.WriteLine();

                try // convert input to interger
                {
                    max = Convert.ToInt32(Console.ReadLine());
                }
                catch // if wrong input we try again
                {
                    Console.WriteLine("Numbers only!"); // warning message
                    System.Threading.Thread.Sleep(2500); // makes the program pause for 2.5 sec - just to show warning
                }
                Console.Clear(); // Clearing console of the catch message 
            }

            // Probably not the right way to go about making some structure to the output. 
            // Max input for triplets is 100 just because of this.
            Console.WriteLine("    | A^2 |    | B^2 |    | SquareRoot of C |\n    |_____|    |_____|    |_________________|");

            for (int a = 1; a < max; a++) // running through a 
                for (int b = 1; b < max; b++) // running through b
                    for (int c = 1; c < max; c++) // running through c
                        if (a * a + b * b == c * c) // printing output if the numbers run through fits with pythagorian theorem
                            Console.WriteLine($"    | {a,2}  |    | {b,2}  |    | {c,9}       |"); // output
            Console.ReadLine(); // waiting for 'enter' to be able to view the output
        }
    }
}
