using System;

namespace Exercise_19
{
    /*
     * Exercise 19
     * 
     * Description:
     * Prompt the user to enter two numbers.
     * Use a for-loop to calculate the sum of all the numbers from the first number entered to the second number entered.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 19";

            string userInput = "";
            int userNumber1 = -1;
            int userNumber2 = -1;

            bool enterAgain = false;
            do // Loops as long as the user wants to enter two numbers
            {
                bool isValidNumber = false;
                do // Loop to ask the user to enter their first number
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
                do // Loop to ask the user to enter their second number
                {
                    // Ask the user to enter another number
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

                int sumOfAllNumbers = GetSumOfAllNumbersFromChosenNumbers(userNumber1, userNumber2);

                // Print the sum of all the numbers from the first number entered to the second number entered
                Console.WriteLine($"The sum of all the numbers from {userNumber1} to {userNumber2} is {sumOfAllNumbers}.");

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

        public static int GetSumOfAllNumbersFromChosenNumbers(int userNumber1, int userNumber2)
        {
            int sum = 0;
            // for-loop to calculate the sum of all the numbers from the first number entered to the second number entered
            for (int i = userNumber1; i < userNumber2 + 1; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
