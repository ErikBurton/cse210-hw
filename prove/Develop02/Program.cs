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
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
       }
       
    }
}