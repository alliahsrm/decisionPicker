using System;

namespace decisionWheel
{
    class Program
    {
        static void Main()
        {
            // Create a new instance of the Random class
            Random rand = new Random();

            // Initialize variables to keep track of the number of "Yes" and "No" responses and the number of times the program has run
            int yesCount = 0;
            int noCount = 0;
            int numIterations = 0;

            // Create a while loop that will run as long as the number of iterations is less than 3
            while (numIterations < 3)
            {
                // Display a menu to the user
                Console.WriteLine("Welcome to Decision Wheel Roulette! ");
                Console.WriteLine("1. Get a random decision for 3 times.");
                Console.WriteLine("2. Exit the program.");

                // Get the user's choice
                int userChoice = Convert.ToInt32(Console.ReadLine());

                // Check the user's choice
                if (userChoice == 1)
                {
                    // Generate a random number between 0 and 1
                    int randomNum = rand.Next(2);

                    // Check the random number
                    if (randomNum == 0)
                    {
                        // Increment the "Yes" count and display "Yes"
                        yesCount++;
                        Console.WriteLine("Random decision: Yes");
                    }
                    else
                    {
                        // Increment the "No" count and display "No"
                        noCount++;
                        Console.WriteLine("Random decision: No");
                    }

                    // Increment the number of iterations
                    numIterations++;

                    // Check if the program has run three times
                    if (numIterations == 3)
                    {
                        // Display the final decision based on the count of "Yes" and "No" responses
                        Console.WriteLine("Press enter to get the final decision:");
                        Console.ReadLine();

                        if (yesCount > noCount)
                        {
                            Console.WriteLine("Final decision: Yes");
                            Console.WriteLine("Thank you for using Decision Wheel! ");
                        }
                        else if (noCount > yesCount)
                        {
                            Console.WriteLine("Final decision: No");
                            Console.WriteLine("Thank you for using Decision Wheel! ");
                        }
                        else
                        {
                            Console.WriteLine("Final decision: Undecided");
                            Console.WriteLine("Thank you for using Decision Wheel! ");
                        }
                    }
                }
                else if (userChoice == 2)
                {
                    // Exit the program if the user selects option 2
                    Console.WriteLine("Exiting the program... ");
                    break;
                }
                else
                {
                    // Display an error message if the user enters an invalid input
                    Console.WriteLine("Error: invalid input");

                }
            }
        }
    }
}