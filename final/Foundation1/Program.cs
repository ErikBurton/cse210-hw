using System;

class Program
{
    static void Main()
    {
        // Create 3-4 videos and adds comments
        List<Video> videos = new List<Video>();

        // Creats video1 = new Video
        Video video1 = new Video
        {
            Title = "Intro to Databases",
            Author = "Bob Smith",
            LengthInSeconds = 1200
        };
        video1.AddComment("Erik Burton", "Great video! Learned a lot.");
        video1.AddComment("Ashu Yadav", "Learned a lot in a short time.");

        // Creates video2 and adds comments
        Video video2 = new Video
        {
            Title = "C# in 30 Minutes",
            Author = "Jarad Dingman",
            LengthInSeconds = 1800
        };
        video2.AddComment("Neil Peart", "Good video for beginners.");
        video2.AddComment("Alex Lifeson", "Blah, blah, blah.");
        video2.AddComment("Geddy Lee", "Good Day, Eh!");

         // Creates video3 and adds comments
        Video video3 = new Video
        {
            Title = "Muscle Car and Corvette Nationals 2023",
            Author = "Jeff Oesto",
            LengthInSeconds = 2700
        };
        video3.AddComment("Sami Ebelt", "I really liked the Camaros!");
        video3.AddComment("Cheryl Sumpter", "Great Quality Video. I felt like I was there!");
        video3.AddComment("Joe Colca", "Where were the Tesla's?");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}