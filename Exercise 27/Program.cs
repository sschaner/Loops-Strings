using System;
using System.Text.RegularExpressions;

namespace Exercise_27
{
    /*
     * Exercise 27
     * 
     * Description:
     * Prompt the user to enter some text
     * Count and output how many consonants were in the string.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Title();

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                string userString = EnterText();
                int numberOfConsonants = GetConsonantCount(userString);
                string termPlurality = DetermineCorrectPluralUsage("cononant", numberOfConsonants);
                Console.WriteLine($"There are {numberOfConsonants} {termPlurality}.");

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
            Console.Title = "Exercise 27";
        }

        // Ask the user to enter a sentence
        public static string EnterText()
        {
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static int GetConsonantCount(string userString)
        {
            // Replace all the word characters from userString with nothing
            string stringWithoutNonLetterCharacters = Regex.Replace(userString, @"[^\w]", "");

            char[] stringLetters = stringWithoutNonLetterCharacters.ToCharArray();
            int consonantCounter = 0;

            // Loop through characters and increase vowel count if necessary
            for (int i = 0; i < stringLetters.Length; i++)
            {
                // Increment consonant count if any character is a consonant
                switch (stringLetters[i].ToString().ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        break;
                    default:
                        // Increment consonant counter
                        consonantCounter++;
                        break;
                }
                
            }
            return consonantCounter;
        }

        public static string DetermineCorrectPluralUsage(string term, int termCount)
        {
            // If count > 1, add an 's'
            if (termCount > 1)
            {
                return term + "s";
            }
            else
            {
                return term;
            }
        }
    }
}
