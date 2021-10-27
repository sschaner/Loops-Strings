using System;

namespace Exercise_20
{
    /*
     * Exercise 20
     * 
     * Description:
     * Prompt the user to enter a number.
     * Use a for-loop to calculate the product of the number and the two preceding numbers.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 20";

            string userInput = "";
            int userNumber = -1;

            bool enterAgain = false;
            do // Loops as long as the user wants to enter a number
            {
                bool isValidNumber = false;
                do // Loop to ask the user to enter a number
                {
                    // Ask the user to enter a number
                    Console.Write("Enter a number: ");
                    userInput = Console.ReadLine();
                    isValidNumber = int.TryParse(userInput, out userNumber);
                    if (isValidNumber == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number.");
                        Console.ResetColor();
                    }

                } while (isValidNumber == false);

                int productOfAllNumbers = GetProductOfChosenNumberAndPrevTwoNumbers(userNumber);

                // Print the sum of all the numbers from the first number entered to the second number entered
                Console.WriteLine($"The product of {userNumber}, {userNumber - 1}, and {userNumber - 2} is {productOfAllNumbers}.");

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

        public static int GetProductOfChosenNumberAndPrevTwoNumbers(int userNumber)
        {
            int product = 1;
            // for-loop to calculate the sum of all the numbers from the first number entered to the second number entered
            for (int i = userNumber; i >= userNumber - 2; i--)
            {
                product = product * i;
            }

            return product;
        }
    }
}
