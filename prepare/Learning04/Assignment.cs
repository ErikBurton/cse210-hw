using System;

class Assignment
{
    //  Protected member variables
    protected string studentName;
    protected string topic;

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