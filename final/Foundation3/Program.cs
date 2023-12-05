using System;

// Program class
class Program
{
    static void Main()
    {
        // Create instances of each event type
        var lecture = new Lecture("Amazing Lecture", "A fascinating talk about something", DateTime.Now, new TimeSpan(14, 0, 0),
            new Address("123 Main St", "Cityville", "State", "12345"), "John Doe", 50);

        var reception = new Reception("Grand Reception", "An elegant gathering", DateTime.Now.AddDays(7), new TimeSpan(18, 30, 0),
            new Address("456 Oak St", "Townsville", "State", "67890"), "rsvp@example.com");

        var outdoorGathering = new OutdoorGathering("Community Picnic", "Join us for fun and food", DateTime.Now.AddDays(14),
            new TimeSpan(12, 0, 0), new Address("789 Pine St", "Villageton", "State", "56789"), "Sunny with a chance of rain");

        // Generate and display marketing messages
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GenerateStandardDetails());
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}