using System;

    class Program 
    {
        static void Main(string[] args) 
        {
            // Step 1 - Ask user for a magic number
            // Console.Write("What is your magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            // Step 3 - Generate a random number from 1 to 100
             Random randomGenerator = new Random();
             int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            // Step 2 - Add a loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if(magicNumber > guess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }