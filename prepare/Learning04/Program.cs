using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Assignment instance
        Assignment assignment = new Assignment("Erik Burton", "Drum Set Performance");

        // Call the GetSummary method and display the summar
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

    }
}