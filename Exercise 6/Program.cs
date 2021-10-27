using System;

namespace Exercise_6
{
    /*
     * Exercise 6
     * 
     * Description:
     * Use a do-while loop to output "Hello World!" in a loop.
     * Each time you output "Hello, World!", ask the user whether they wold like to continue.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string finishedAnswerText = "";
            bool finished = false;
            bool continueAsking = false;
            string userInput = "";

            do
            {
                Console.WriteLine("Hello, World!");

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
