using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_29
{
    /*
     * Exercise 28
     * 
     * Description:
     * Prompt the user to enter some text.
     * Remove all the vowels and output the text.
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
                RemoveVowelsFromMiddleOfWords(userString);

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
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
            Console.Title = "Exercise 29";
        }

        // Ask the user to enter a sentence
        public static string EnterText()
        {
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void RemoveVowelsFromMiddleOfWords(string stringToBeSplit)
        {
            string stringWithoutVowelsInMiddle = "";
            foreach (string word in stringToBeSplit.Split(" "))
            {
                // Remove the middle vowel(s) from each word in the sentence (Leave vowels at the beginning or end of words)
                stringWithoutVowelsInMiddle = Regex.Replace(word, @"(?<!^)[aeiouAEIOU](?!\W)", "");
                Console.Write($"{stringWithoutVowelsInMiddle} ");
            }  
        }
    }
}
