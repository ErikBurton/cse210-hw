// Class to represent circles
public class Circle : Shape // Inherits from the base class

{
    private double _radius; // Private variable to store radius

    private Circle(string color, double _radius) // Constructor to initialize color and radius
        : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius
    }
}