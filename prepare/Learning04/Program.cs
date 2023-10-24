using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new mathAssignment instance
        MathAssignment mathAssignment = new MathAssignment("Erik Burton", "Drum Set Performance", "Independence", "Paradiddles");

        // Call the GetSummary method from the base class
        string summary = mathAssignment.GetSummary();
        Console.WriteLine("Assignment Summary");
        Console.WriteLine(summary);

        // Call the GetHomeworkList method from the derived list
        string homeworkList = mathAssignment.GetHomeWorkList();
        Console.WriteLine("\nHomework List:");
        Console.WriteLine(homeworkList);

    }
}