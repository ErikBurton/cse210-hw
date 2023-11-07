// Classs for a rectangle
public class Rectangle
{
    private double _length; // Private variable to store the length
    private double _width; // Private variable to store the width

    public Rectangle(string color, double length, double width) // Constructor to initilize the color, lenght and width
        : base(color)
        {
            _length = length;
            _width = width;
        }
}