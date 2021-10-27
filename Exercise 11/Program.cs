using System;

namespace Exercise_11
{
    /*
     * Exercise 11
     * 
     * Description:
     * Use a for loop to output all the numbers from 0 to 9
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";

            Console.Title = "Exercise 11";

            do // Loop to finish the application
            {
                // Increments by 1 from 0 to 9
                for (int i = 0; i < 10; i++)
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
