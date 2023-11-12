using System;

class ListingActivity : MindfulnessActivity
{
     private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

     public ListingActivity() : base("Listing Activity", "This activity will help you list positive things in your life.")
    {
    }

    public override void Start()
    {
        base.Start();
        _ListPositiveAspects();
    }

    private void _ListPositiveAspects()
    {
        Random rand = new Random();
        int itemsListed = 0;

        Console.WriteLine("Think about this prompt:");
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        _ShowSpinner(3);

        Console.WriteLine("Start listing positive things:");

        while (duration > 0)
        {
            Console.Write("Enter a positive item (or 'done' to finish): ");
            string item = Console.ReadLine()?.Trim();

            if (item.ToLower() == "done")
                break;

            itemsListed++;
            duration--;
        }

        Console.WriteLine($"You listed {itemsListed} positive items.");
    }
}