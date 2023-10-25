using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new WritingAssignment instance
        WritingAssignment writingAssignment = new WritingAssignment("Erik Burton", "Independence", "Get Funky");

        // Call the GetSummary method from the base class
        string summary = writingAssignment.GetSummary();
        Console.WriteLine("Assignment Summary");
        Console.WriteLine(summary);

        // Call the GetWritingAssignment method from the derived list
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine("\nWriting Assignment:");
        Console.WriteLine(writingInfo);

    }
}