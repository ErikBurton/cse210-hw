using System;

// Creates Job Class
public class Job {
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;


    // Adds a Display method to the Job class
    public void Display() 
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}