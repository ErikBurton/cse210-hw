using System;

// Program class
class Program
{
    static void Main()
    {
        // Create instances of each event type
        var lecture = new Lecture("Talk Like TED", "The 9 public-speaking secrets of the world's top minds", DateTime.Now, new TimeSpan(14, 0, 0),
            new Address("76 Laura St", "Jacksonville", "FL", "92322"), "Carmine Gallo", 50);

        var reception = new Reception("Elder Mower's Homecoming", "Elder Mower returns from his LDS Mission", DateTime.Now.AddDays(7), new TimeSpan(18, 30, 0),
            new Address("11253 Tippecanoe Way", "South Jordan", "UT", "84009"), "rsvp@example.com");

        var outdoorGathering = new OutdoorGathering("All Camaro Car Show", "All year Camaros welcome - Show off your shiny ride", DateTime.Now.AddDays(14),
            new TimeSpan(12, 0, 0), new Address("2189 E Colorado Dr", "St. George", "UT", "84002"), "Sunny with a 100 % chance of cool cars!");

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