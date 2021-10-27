using System;

namespace Exercise_18
{
    /*
     * Exercise 18
     * 
     * Description:
     * Prompt the user to enter a number.
     * Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 18";

            string userInput = "";
            int userNumber = -1;

            bool enterAgain = false;
            do // Loops as long as the user wants to enter a number.
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
                        Console.WriteLine("Please input a valid number.");
                    }

                } while (isValidNumber == false);

                int sumOfAllNumbers = GetSumOfAllNumbersFromChosenNumber(userNumber);

                // Print the sum
                Console.WriteLine(sumOfAllNumbers);

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

        public static int GetSumOfAllNumbersFromChosenNumber(int userNumber)
        {
            int sum = 0;
            // for-loop to calculate the sum of all the numbers
            for (int i = 0; i < userNumber + 1; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
