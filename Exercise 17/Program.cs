using System;

namespace Exercise_17
{
    /*
     * Exercise 17
     * 
     * Description:
     * Use a for loop to output a 2D pyramid of asterisks with a height of 10
     * 
     * This isn't quite working yet
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 17";

            for (int i = 0; i < 10; i++) // gives us 10 rows
            {
                for (int j = 0; j < (10 - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
