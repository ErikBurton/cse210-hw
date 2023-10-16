using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class Entry
{
    // 3 properties for Entry class
    private string Prompt { get; }
    private string Response { get; }
    public string Date { get; }

    // Constructor to create a new jounal entry
    private Entry(string prompt, string response, string date)
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