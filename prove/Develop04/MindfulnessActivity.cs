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
        ShowActivityComnpletion();
        CongratulateUser();
    }

    // Method to set the duration
    protected void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        SetDuration = int.Parse(Console.ReadLine());
    }

    // Method to display the starting message.
    protected void ShowStartingMessage()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine(description);
    }



}