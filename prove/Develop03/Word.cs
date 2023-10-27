// Word class represents one word in the scripture

class Word 
{
    private string text; // Make attribute private to encapsulate it. Private field to store the word's text

    private bool hidden; // Private field to track if the word is hidden

    public Word(string text);
    {
        this.text = text;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public string GetText()
    {
        return text; // Getter method to access the private attribute
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        return hidden ? "______" : text;
    }        
}
