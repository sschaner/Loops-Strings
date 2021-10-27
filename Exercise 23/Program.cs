using System;
using System.Text;

namespace Exercise_23
{
    /*
     * Exercise 23
     * 
     * Description:
     * Prompt the user to enter a string.
     * Extract and output the first ten characters of the string.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 23";

            string userInput = "";
            string userString = "";
            

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                // Ask the user to enter some text
                Console.Write("Enter some text: ");
                userInput = Console.ReadLine();
                userString = userInput;

                char[] stringLetters = userString.ToCharArray();

                string firstTenCharacters = FirstTenCharactersOfTheString(stringLetters);

                Console.WriteLine($"The first ten characters were: {stringLetters}");


                string continueInput = "";
                do // Loop for determining if the user wants to enter a number again
                {
                    // Ask the user if they would like to continue
                    Console.Write("Would you like to continue (y/n)? ");
                    userInput = Console.ReadLine();
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

        public static string FirstTenCharactersOfTheString(char[] stringLetters)
        {
            string firstTenChars = "";
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < stringLetters[9]; i++)
            {
                
                builder.Append(stringLetters[i]);
                
            }
            firstTenChars = builder.ToString();
            return firstTenChars;
        }
    }
}
