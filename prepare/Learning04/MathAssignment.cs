using System;

// MathAssignment class inherits from the base "Assignment class"
class MathAssignment : Assignment
{
    // Private member variables specific to MathAssignment
    private string textbookSection;
    private string problems;

    // Constructor for MathAssignment
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            this.textbookSection = textbookSection;
            this.problems = problems;
        }
    // Method to get the homework list
    public string GetHomeWorkList()
    {
        return $"Textbook Section: {textbookSection}, Problems: {problems}";
    }
}