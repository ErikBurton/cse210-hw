using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date) // Method to add a new entry
    {
        entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries() // Method to display all journal entries
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename) // Method to save the journal entries to a file
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Response}"); // Save entry as a string with '|' as the seperator
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename); // Real all line from the file into an array
            foreach (string line in lines) // Loop through each line in the file.
            {
                string[] parts = line.Split("|"); // Split the line into parts using '|' pipe as a seperator
                if (parts.Length == 3) // Check if there are exactly 3 parts (date, prompt, repsponse)
                {
                    AddEntry(parts[1], parts[2], parts[0]); // Add a new entry using extracted date, prompt and response
                }
            }
        }
    }

}