using System;

// MathAssignment class inherits from the base "Assignment class"
class MathAssignment : Assignment
{
    // Private member variables specific to MathAssignment
    private int assignmentNumber;
    private string homeworkDescription;

    // Constructor for MathAssignment
    public MathAssignment(string studentName, string topic, int assignmentNumber, string homeworkDescription)
        : base(studentName, topic)
        {
            this.assignmentNumber = assignmentNumber;
            this.homeworkDescription = homeworkDescription;
        }
    // Method to get the homework list
    public string GetHomeWorkList()
    {
        return $"Assignment Number: {assignmentNumber}, Homework Description: {homeworkDescription}";
    }
}