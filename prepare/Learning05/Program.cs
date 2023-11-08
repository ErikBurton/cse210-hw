using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(); // Creates and empty list

        // Create instances of Square, Rectangle and Circle and adds them to the list
        shapes.Add(new Square("Yellow", 5.0));
        shapes.Add(new Rectangle("Black", 4.0, 6.0));
        shapes.Add(new Circle("Orange", 3.0));
    

    // Iterate through the list of shapes, display their color and area
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();
        }      
    }
}
    


