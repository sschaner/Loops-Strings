using System;

namespace Exercise_22
{
    /*
     * Exercise 22
     * 
     * Description:
     * Prompt the user to enter two numbers that will determine a range.
     * Then prompt the user to enter another number and check if it is in the range.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 22";

            string userInput = "";
            int userNumber1 = -1;
            int userNumber2 = -1;
            int numberInRange = -1;

            bool enterAgain = false;
            do // Loops as long as the user wants to enter a number
            {
                bool isValidNumber = false;
                do // Loop to ask the user to enter a number
                {
                    // Ask the user to enter a number
                    Console.Write("Enter a number: ");
                    userInput = Console.ReadLine();
                    isValidNumber = int.TryParse(userInput, out userNumber1);
                    if (isValidNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number.");
                        Console.ResetColor();
                    }

                } while (isValidNumber == false);

                isValidNumber = false;
                do // Loop to ask the user to enter another number
                {
                    // Ask the user to enter a number
                    Console.Write("Enter another number: ");
                    userInput = Console.ReadLine();
                    isValidNumber = int.TryParse(userInput, out userNumber2);
                    if (isValidNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number.");
                        Console.ResetColor();
                    }

                } while (isValidNumber == false);

                Console.WriteLine($"Your range is {userNumber1} - {userNumber2}.");

                isValidNumber = false;
                do // Loop to enter a number that will be verified if it is in the range
                {
                    // Ask the user to enter a number
                    Console.Write("Enter another number to verify it is in the range: ");
                    userInput = Console.ReadLine();
                    isValidNumber = int.TryParse(userInput, out numberInRange);
                    if (isValidNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number.");
                        Console.ResetColor();
                    }

                } while (isValidNumber == false);


                string numberInTheRange = IsTheNumberInTheRange(numberInRange, userNumber1, userNumber2);

                // Print the sum of all the numbers from the first number entered to the second number entered
                Console.WriteLine(numberInTheRange);

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

        public static string IsTheNumberInTheRange(int userNumber, int userNumber1, int userNumber2)
        {
            string message = "";
            if (userNumber1 <= userNumber && userNumber <= userNumber2)
            {
                message = $"{userNumber} is in the range.";
                return message;
            }
            else
            {
                message = $"{userNumber} is outside the range.";
                return message;
            }

            
        }
    }
}
