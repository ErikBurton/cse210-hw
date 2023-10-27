// Word class represents one word in the scripture

class Word 
{
    private string text; // Make attribute private to encapsulate it. Private field to store the word's text

    private bool hidden; // Private field to track if the word is hidden

    public Word(string text) // Constructor for creating Word oject
    {
        this.text = text; // Initialize the text field
        hidden = false; // Initial hidden to false if the word was not hidden to begin with
    }

    public void Hide() // Method to hide a word
    {
        hidden = true; // Sets hidden to true
    }

    public string GetText() // Getter method to access a word's text
    {
        return text; // Return text field to get the word's text 
    }

    public bool IsHidden() // Method to check if a word is hidden
    {
        return hidden; // Returns hidden field to see if a word is hidden
    }

    public override string ToString() // Override the ToString method
    {
        return hidden ? "______" : text; // Return a line of underscores or the text, depending on if a word is hidden
    }        
}
