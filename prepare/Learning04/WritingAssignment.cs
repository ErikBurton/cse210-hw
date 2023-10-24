using System;

// WritingAssignment class inherits from the base "Assignment class"
class WritingAssignment : Assignment
{
   // Private member variable specific to WritingAssignment
    private string title;

    // Constructor for WritingAssignment
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
        {
            this.title = title;
        }

    // Method to get writing info
    public string GetWritingInformation()
    {
        string studentName = GetStudentName(); // Access the studentName
        return $"Student Name: {studentName}, Topic: {topic}, Title: {title}";
    }

    // Public method to get the studentname attribute for the base class
    public string GetStudentName()
    {
        return studentName;
    }


}