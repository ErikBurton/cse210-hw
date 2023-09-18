using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    

            // Step 1 - ask user for magic number
            Console.Write("Enter the magic number: ");
            int magicNumber int.Parse(Console.ReadLine());

            int guess;

            // Step 2 - loop until guess is correct
            do {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

            if(guess < magicNumber) {
                Console.Write("Higher!");
            } else if (guess > magicNumber) {
                Console.Write("Lower!");
            } else {
                Console.Write("You guessed it!");
            }
            } while (guess != magicNumber);


        }
    }
}
}