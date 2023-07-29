using System;
using System.Collections.Generic;

namespace decisionPicker
{
    class Program
    {
        static void Main()
        {
            DecisionManager decisionPicker = new DecisionManager();

            while (true)
            {
                Console.WriteLine("Welcome to the Decision Picker!\n");
                Console.WriteLine("This program will help you decide on things you can't choose for yourself.");
                Console.WriteLine("Just pick a number below to navigate this program...\n");
                Console.WriteLine("1. Insert how many choices");
                Console.WriteLine("2. Show decision history");
                Console.WriteLine("3. Exit the program");

                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        List<string> choices = GetChoices();
                        decisionPicker.AddChoices(choices);
                        break;
                    case 2:
                        ShowDecisionHistory(decisionPicker);
                        break;
                    case 3:
                        Console.WriteLine("\nExiting the program...");
                        return;
                    default:
                        Console.WriteLine("\nError: Invalid input.");
                        break;
                }

                if (userInput == 1)
                {
                    string pickedChoice = decisionPicker.MakeDecision();
                    if (!string.IsNullOrEmpty(pickedChoice))
                    {
                        Console.WriteLine($"\nFINAL DECISION: {pickedChoice}");
                        Console.WriteLine("Thank you for using Decision Picker!");
                    }
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

        static List<string> GetChoices()
        {
            Console.WriteLine("\nPlease enter how many choices:");
            int numChoices = Convert.ToInt32(Console.ReadLine());

            List<string> choices = new List<string>();

            for (int i = 1; i <= numChoices; i++)
            {
                Console.WriteLine($"Please enter choice {i}:");
                choices.Add(Console.ReadLine()!);
            }

            return choices;
        }

        static void ShowDecisionHistory(DecisionManager decisionPicker)
        {
            List<string> history = decisionPicker.GetDecisionHistory();
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
