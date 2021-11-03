using System;

namespace Exercise_25
{
    /*
     * Exercise 25
     * 
     * Description:
     * Prompt the user to enter a sentence.
     * Split the sentence into individual words and display each word on its own line.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Title();

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                string userString = EnterSentence();
                SeparateWordsFromSentence(userString);

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("Would you like to continue (y/n)? ");
                    string userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        enterAgain = true;
                    }
                    else if (continueInput.ToLower().Trim() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        enterAgain = false;
                        goto Exit;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'y' or 'n'");
                    }
                } while (continueInput.ToLower().Trim() != "y");

            } while (enterAgain == true);

        Exit:

            Console.ReadKey();
        }

        // shows the title of the application
        public static void Title()
        {
            Console.Title = "Exercise 25";
        }

        // Ask the user to enter a sentence
        public static string EnterSentence()
        {
            Console.Write("Enter a sentence: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void SeparateWordsFromSentence(string userString)
        {
            string[] words = userString.Split(" ");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
