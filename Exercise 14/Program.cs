using System;

namespace Exercise_14
{
    /*
     * Exercise 14
     * 
     * Description:
     * Prompt the user for a number.
     * Use a for loop to output the squares of all the numbers from 1 to that number.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";
            int userNumber = -1;

            Console.Title = "Exercise 14";

            do // Loop to finish the application
            {
                // Prompt the user for a number.
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                userNumber = int.Parse(userInput);

                // Give a list of all the sqares from 1 to the chosen number
                for (int i = 1; i <= userNumber; i++)
                {
                    Console.Write($"{Math.Pow(i, 2)} "); // Math.Pow(base, power)
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
