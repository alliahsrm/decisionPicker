using System;

namespace decisionWheel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Random class
            Random rand = new Random();

            // Initialize variables to keep track of the choices and the number of times the program has run
            string[] choices;
            int numChoices = 0;

            while (true)
            {
                Console.WriteLine("Welcome to Decision Wheel Roulette!");
                Console.WriteLine("1. Insert how many choices.");
                Console.WriteLine("2. Exit the program.");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.Write("Please enter how many choices: ");
                        numChoices = Convert.ToInt32(Console.ReadLine());

                        if (numChoices < 2)
                        {
                            Console.WriteLine("\nError: Invalid input. You need to enter at least 2 choices.\n");
                            break;
                        }

                        choices = new string[numChoices];

                        for (int i = 0; i < numChoices; i++)
                        {
                            Console.Write($"Please enter choice {i + 1}: ");
                            choices[i] = Console.ReadLine();
                        }

                        int finalIndex = rand.Next(numChoices);
                        string finalChoice = choices[finalIndex];

                        Console.WriteLine("\nFinal decision:");
                        Console.WriteLine(finalChoice);
                        Console.WriteLine("Thank you for using Decision Wheel!");
                        return;

                    case 2:
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Error: Invalid input. Please choose option 1 or 2.");
                        break;
                }
            }
        }
    }
}