using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    // 3 properties for Entry class
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    // Constructor to create a new jounal entry
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

// ToString method provides formatted string repsenstation of the entry
    public override string ToString()
    {
        return $"{Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}