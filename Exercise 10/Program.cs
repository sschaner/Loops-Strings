using System;

namespace Exercise_10
{
    /*
     * Exercise 10
     * 
     * Description:
     * Determine whether the user is tall enough to ride a roller coaster.
     * Prompt the user to enter her height in inches.
     * If she is less than 54 inches tall, notify her that she cannot ride the Raptor.
     * If she is at least 54 inches tall, notify her that she can ride the Raptor.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";
            double userHeight = 0.0d;
            double heightDifference = 0.0d;

            Console.Title = "Conditionals, Exercise 2";

            do
            {
                // Prompt the user to enter their height in inches
                Console.Write("Enter your height in inches: ");
                userInput = Console.ReadLine();
                userHeight = double.Parse(userInput);

                heightDifference = Math.Round(54 - userHeight, 1);

                if (userHeight < 54)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {heightDifference} more inches.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Great, you can ride the Raptor!");
                    Console.ResetColor();
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

            Console.ReadKey();
        }
    }
}
