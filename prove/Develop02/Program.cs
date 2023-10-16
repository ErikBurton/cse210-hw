using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Journal class to manage journal entries
       Journal journal = new Journal();

       // Loop to display the menu and handle user interaction
       while (true)
       {
            // Display the menu options
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                // Use a switch statement to process the user's menu choice
                switch (choice)
                {
                    case 1:
                        // Prompt use to enter a response and date
                        Console.WriteLine("Enter your response: ");
                        string response = Console.ReadLine();
                        Console.WriteLine("Enter the date: ");
                        string date = Console.ReadLine();
                        string[] prompts = {
                            "Who was the most interesting person I interacted with today?",
                            "What was the best part of my day?",
                            "How did I see the hand of the Lord in my life today?",
                            "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"
                    };

                        // Selects a random prompt from the prompts array
                        string randomPrompt = prompts[new Random().Next(prompts.Length)];

                        // Add user's entry to the journal
                        journal.AddEntry(randomPrompt, response, date);
                        break;
                    case 2:
                        // Display all journal entries
                        journal.DisplayEntries();
                        break;
                    case 3:
                        // Prompt user to enter a file name to the save the journal to a file
                        Console.WriteLine("Enter the filename to save your journal: ");
                        string saveFilename = Console.ReadLine();
                        // Save the journal to the specified file
                        journal.SaveToFile(saveFilename);
                        break;
                    case 4:
                        // Exit the program
                        Environment.Exit(0);
                        break;
                    default:
                        // Handle an invalid choice
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;          
                }
            }
            else
            {
                // Handle invalid user input (not a valid number)
                Console.WriteLine("Invalid input. Please enter a valid number. ");
            }
       }       
    }
}