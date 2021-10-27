using System;

namespace Exercise_9
{
    /*
     * Exercise 9
     * 
     * Description:
     * Prompt the user to enter a language.
     * Based on the language the user input gives, display "Hello, World!" in that language.
     * Use a switch statement to choose what to display.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            bool continueAsking = false;
            string finishedAnswerText = "";
            string userInput = "";
            string languageChosen = "";
            string message = "";

            Console.Title = "Conditionals - Bonus 1";

            do
            {
                Console.Write("Enter a language: ");
                userInput = Console.ReadLine();
                languageChosen = userInput;

                switch (languageChosen.ToLower().Trim())
                {
                    case "english":
                        message = "Hello, World!";
                        break;
                    case "spanish":
                        message = "Hola Mundo!";
                        break;
                    case "dutch":
                        message = "Hallo wereld!";
                        break;
                    default:
                        message = "I only know 3 languages. They are English, Spanish, and Dutch. Please enter one of the languages I know.";
                        break;
                }

                Console.WriteLine(message);

                do // Loop to continue with validation for 'y' or 'n'
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nContinue (y/n)? ");
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
