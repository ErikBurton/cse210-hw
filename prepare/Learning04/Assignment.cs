using System;

class Assignment
{
    //  Private member variables
    private string studentName;
    private string topic;

    // Constructor to initialize member variables
    public Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"Student Name: {studentName}, Topic: {topic}";
    }
}