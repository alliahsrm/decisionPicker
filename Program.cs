using System;
using System.Collections.Generic;

namespace decisionWheel
{
    class Program
    {
        static List<string> history = new List<string>();

        static void Main()
        {
            Random rand = new Random();
            List<string> choices = new List<string>();

            while (true)
            {
                Console.WriteLine("Welcome to the Decision Wheel Roulette!\n");
                Console.WriteLine("This program will help you decide on things you can't choose for yourself.");
                Console.WriteLine("Just pick a number below to navigate this program...\n");
                Console.WriteLine("1. Insert how many choices");
                Console.WriteLine("2. Show history");
                Console.WriteLine("3. Exit the program");

                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        InsertChoices(rand, choices);
                        break;
                    case 2:
                        ShowHistory();
                        break;
                    case 3:
                        Console.WriteLine("\nExiting the program...");
                        return;
                    default:
                        Console.WriteLine("\nError: Invalid input.");
                        break;
                }

                Console.WriteLine("\nPress '4' to use the program again or '5' to exit.");

                string exitInput = Console.ReadLine()!;

                if (exitInput == "5")
                {
                    Console.WriteLine("\nExiting the program...");
                    return;
                }

                while (exitInput != "4" && exitInput != "5")
                {
                    Console.WriteLine("\nError: Invalid input.");
                    Console.WriteLine("Press '4' to use the program again or '5' to exit.");

                    exitInput = Console.ReadLine()!;

                    if (exitInput == "5")
                    {
                        Console.WriteLine("\nExiting the program...");
                        return;
                    }
                }

                Console.WriteLine();
            }
        }

        static void InsertChoices(Random rand, List<string> choices)
        {
            Console.WriteLine("\nPlease enter how many choices:");
            int numChoices = Convert.ToInt32(Console.ReadLine());

            choices.Clear();

            for (int i = 1; i <= numChoices; i++)
            {
                Console.WriteLine($"Please enter choice {i}:");
                choices.Add(Console.ReadLine()!);
            }

            string finalChoice = "";

            if (choices.Count > 0)
            {
                int randomIndex = rand.Next(choices.Count);
                finalChoice = choices[randomIndex].ToUpper();
            }

            Console.WriteLine($"\nFinal decision: {finalChoice}");
            Console.WriteLine("Thank you for using Decision Wheel!");

            history.Add(finalChoice);

            Console.WriteLine();
        }

        static void ShowHistory()
        {
            Console.WriteLine("\nDecision history:");

            if (history.Count == 0)
                Console.WriteLine("No history available.");
            else
                foreach (string choice in history)
                    Console.WriteLine(choice);

            Console.WriteLine();
        }
    }
}
