using System;
using System.Collections.Generic; // use Generics library

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Create a list to store numbers.
        int input; 
                
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if(input != 0)
                numbers.Add(input); // Append each number to the list.

        } while (input !=0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum(); // Compute the sum of the numbers.
            double average = numbers.Average(); // Compute the average of the numbers.
            int max = numbers.Max(); // Find the max number.

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
                
    }
}