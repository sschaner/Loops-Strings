using System;

namespace Exercise_16
{
    /*
     * Exercise 16
     * 
     * Description:
     * Use a for loop to output a triangle of asterisks with a height of 10
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 16";

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
