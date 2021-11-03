using System;

namespace Exercise_24
{
    /*
     * Exercise 24
     * 
     * Description:
     * Prompt the user to enter a string.
     * Extract and output the last ten characters of the string.
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
                string lastTen = LastTenCharactersOfTheString(userString);
                Console.WriteLine($"The last ten characters were: {lastTen}");


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
            Console.Title = "Exercise 24";
        }

        // Ask the user to enter some text
        public static string EnterText()
        {
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string LastTenCharactersOfTheString(string userString)
        {
            if (userString.Length < 10)
            {
                return userString;
            }
            else
            {
                string lastTenCharacers = userString.Substring(userString.Length - 10, 10);
                return lastTenCharacers;
            }
        }
    }
}
