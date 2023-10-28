// Scripture class represents the scripture itself

class Scripture
{
    private Reference reference; // Private field to hold a reference to the scripture's reference    
    private List<Word> words = new List<Word>(); // Private list to hold words in the scripture

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words.AddRange(scriptureText.Split(' ').Select(word => new Word(word)));
    }

    // Hide a random word in the scripture
    public void HideRandomWord()
    {
        List<Word> unhiddenWords = words.Where(word => !word.Hidden).ToList();
        if (unhiddenWords.Count > 0)
        {
            Word wordToHide = unhiddenWords[new Random().Next(unhiddenWords.Count)];
            wordToHide.Hide();
        }
    }

    // Check if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public override string ToString()
    {
        return $"{reference}\n{string.Join(" ", words)}";
    }
}
