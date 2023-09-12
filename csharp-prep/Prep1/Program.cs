using System;

class Program
{
    static void Main(string[] args) 
    {
        // Use Console.Write() to print a prompt.
        Console.Write("What is your first name? ");
        // Store the first name in a variable.
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        // Store the last name in a variable.
        string lastName = Console.ReadLine();

        // Print the full name using string interpoloaton ($"")
        // Print the last name first and then the first name and again the last name for the desired format.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }
}