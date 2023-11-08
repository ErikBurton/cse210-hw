// Class for Square
public class Square : Shape // Inherits from the base class
{
    private double _side; // Private variable to store side of a square

    public Square(string color, double side) // Constructor to initialize color and side of the square
        : base(color)
    {
        _side = side;
    }

    public override double GetArea() // Polymorphism: Override the GetArea method for squares to calculate their area
    {
        return _side * _side; // Calculate the area of a square
    }
}