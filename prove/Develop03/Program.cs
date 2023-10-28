#nullable enable

string referenceText = "John 3:16";

static string? GetUserInput()
{
    return Console.ReadLine();
}

// Scripture reference and text
string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

Scripture scripture = new Scripture(referenceText, scriptureText);

// Main loop. Allow user to hide words in the scripture
while (!scripture.AllWordsHidden())
{
    Console.Clear();
    Console.WriteLine(scripture);
    Console.WriteLine("Press Enter to hide a word or type 'quit' to exit. ");
    string userInput = GetUserInput() ?? "";

    if (userInput.ToLower() == "quit")
        break;

    scripture.HideRandomWord();

// Show the final scripture with hidden words
Console.Clear();
Console.WriteLine(scripture);
}