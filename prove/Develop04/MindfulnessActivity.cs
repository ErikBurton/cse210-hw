using System;
using System.Dynamic;
using System.Reflection.Emit;

class MindfulnessActivity
{
    protected string name;
    protected string description;

    // ConstructorBuilder to initialize name and description
    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // Start method for mindfulness activity
    public virtual void Start()
    {
        SetDuration();
        ShowStartingMessage();
        PrepareToBegin();

    }

    // End method for mindfulness activity
    public virtual void End()
    {
        ShowActivityCompletion();
        CongratulateUser();
    }

    // Method to set the duration
    protected void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        SetDuration = int.Parse(Console.ReadLine());
    }

    // Method to display the starting message
    protected void ShowStartingMessage()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine(description);
    }

     // Method to prepare the user to begin the activity
    protected void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin in 3 seconds...");
        Thread.Sleep(3000);
    }

    // Method to show the completion message
    protected void ShowActivityCompletion()
    {
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
    }

    // Method to congratulate the user
    protected void CongratulateUser()
    {
        Console.WriteLine("Great job! Keep practicing mindfulness.");
    }



}