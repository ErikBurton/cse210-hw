// Reference class represents the scripture reference

class Reference
{
    public string ReferenceText { get; } // Public property stores the scripture reference

    // Constructor for creating a Reference object
    public Reference(string referenceText)
    {
        ReferenceText = referenceText; // Initializes the ReferenceText property with referenceText
    }

    // Method override toString    
    public override string ToString()
    {
        return ReferenceText; // Text to show the reference when ToString() is called
    }
}