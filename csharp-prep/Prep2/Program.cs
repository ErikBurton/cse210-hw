using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90) {
            letter = "A";
        }
        else if (percentage >= 80) {
            letter = "B";
        }
        else if (percentage >= 70) {
            letter = "C";
        }
        else if(percentage >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

      
        Console.WriteLine($"Your grade is: {letter}");

      
        if (percentage >= 70) {
            Console.WriteLine("Congratulations, you have passed the class!");
        }
        else {
            Console.WriteLine("Better luck next time!");
        }
    }
}