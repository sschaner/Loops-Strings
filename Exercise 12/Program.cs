using System;

namespace Exercise_12
{
    /*
     * Exercise 12
     * 
     * Description:
     * Output all the numbers from 9 to 0.
     * Use a for loop to output all the numbers from 9 to 0.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";

            Console.Title = "Exercise 12";

            do // Loop to finish the application
            {
                // Decrements by 1 from 9 to 0
                for (int i = 9; i >= 0; i--)
                {
                    Console.Write($"{i} ");
                }

                do // Loop to continue with validation for 'y' or 'n'
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    finishedAnswerText = userInput = Console.ReadLine();

                    if (finishedAnswerText.ToLower().Trim() == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Goodbye!");
                        Console.ResetColor();
                        finished = true;
                        continueAsking = false;
                    }
                    else if (finishedAnswerText.ToLower().Trim() == "y")
                    {
                        continueAsking = false;
                        continue;
                    }
                    else
                    {
                        continueAsking = true;
                        Console.WriteLine("Please enter either 'y' or 'n'.");
                    }
                } while (continueAsking == true);

            } while (finished == false);

            Console.ReadLine();
        }
    }
}
