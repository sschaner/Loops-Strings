using System;

namespace Exercise_13
{
    /*
     * Exercise 13
     * 
     * Description:
     * Prompt the user for a number.
     * Use a for a for loop to output all the numbers from that number to 0.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";
            double userNumber = 0.0d;

            Console.Title = "Exercise 13";

            do // Loop to finish the application
            {
                // Prompt the user for a number.
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                userNumber = double.Parse(userInput);

                // Decrement by 1 from the chosen number to 0
                for (double i = userNumber; i >= 0; i--)
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
