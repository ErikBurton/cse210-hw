using System;

class Program
{
    static void Main(string[] args)
    {
     while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice))
            {
        
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1, 2, 3, or 4).");
            }


            if (choice == 4)
            {
                break;
            }

            MindfulnessActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    continue;
            }

            activity.Start();
            activity.End();
        }
    }
}
