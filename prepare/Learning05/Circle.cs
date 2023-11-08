// Class to represent circles
public class Circle : Shape // Inherits from the base class

{
    private double _radius; // Private variable to store radius

    public Circle(string color, double radius) // Constructor to initialize color and radius
        : base(color)
    {
        _radius = radius;
    }

    public override double GetArea() // Polymorphism: Override the GetArea for circles to calculate their area
    {
        return Math.PI * _radius * _radius; // Calculate the area of the circle
    }
}