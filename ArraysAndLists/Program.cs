using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray01 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("These are the numbers in myArray01...");
            foreach (int i in myArray01)
            {
                Console.WriteLine(i);
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            Console.WriteLine();
            List<int> myEvens = new List<int>();
            List<int> myOdds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in myArray01)
            {
                if (i % 2 == 0)

                    myEvens.Add(i);

                else
                    myOdds.Add(i);
           
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int i in myEvens)
            {
                Console.WriteLine($"{i}  is an even number");

            }


            
            foreach (int i in myOdds)
            { 
                Console.WriteLine($"{i}  is an odd number");

            }




        }

       

    }
}
