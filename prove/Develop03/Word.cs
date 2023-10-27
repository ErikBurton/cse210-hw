// Word class represents one word in the scripture

using System.ComponentModel.DataAnnotations;

class Word 
{
    private string text; // Make attribute private to encapsulate it

    private bool hidden;

    public Word(string text)
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
}