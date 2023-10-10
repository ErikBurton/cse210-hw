using System;

public class Fraction // Class to hold Fraction function
{
    private int _top; // first attirbute
    private int _bottom; // second attribute

    public int top // Create setter & getter for top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int bottom // Create setter & getter for bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }

    public Fraction() // initializes 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int wholeNum) // initilizes bottom to 1
    {
        _top = wholeNum; 
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom) // initializes two parameters
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() // method returns a fraction in form 3/4
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() // method returns a double by dividing the top number by the bottom number
    {
        return (double)_top / (double)_bottom;
    }
}