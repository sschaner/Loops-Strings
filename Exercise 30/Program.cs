using System;
using System.Text;

namespace Exercise_30
{
    /*
     * Exercise 30
     * 
     * Description:
     * Prompt the user to enter some text.
     * Reverse the text.
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
                string reverseUserString = ReverseString(userString);
                Console.WriteLine(reverseUserString);

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
            Console.Title = "Exercise 31";
        }

        // Ask the user to enter a sentence
        public static string EnterText()
        {
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string ReverseString(string userString)
        {
            char[] stringLetters = userString.ToCharArray();
            string reversedString = "";
            StringBuilder builder = new StringBuilder();

            for (int i = stringLetters.Length - 1; i >= 0; i--)
            {
                builder.Append(stringLetters[i]);
            }
            reversedString = builder.ToString();
            return reversedString;
        }
    }
}
