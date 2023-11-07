// Class to represent shapes
public class Shape
{
    private string _color; // Private member to store the color of the shape

    public Shape(string color) // Constructor to initialze the color
    {
        _color = color; 
    }

    public string GetColor() // Getter to retrieve the color
    {
        return _color;
    }

    public virtual double GetArea() // Polymorphism - Virtual method to calculate the area
    {
        return 0; // Bass class returns 0 
    }  
}