using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message to the user
        DisplayWelcome();

        // Prompt the user for their name and store it in a variable
        string userName = PromptUserName();

        // Prompt the user for their favorite number and store it in a variable
        int userNumber = PromptUserNumber();

        // Calculate the square of the user's number and store it in a variable
        int squaredNumber = SquareNumber(userNumber);

        // Display the result, including the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // Function to prompt user for their name as return it as a string
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number; ");
        return int.Parse(Console.ReadLine());
    }
    // Function to calculate the squre of a number and return it as an integer
    static int SquareNumber (int number)
    {
        return number * number;
    }
    // Funtion to display the result, including the user's name and the squared number
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}