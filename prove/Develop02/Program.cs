using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
       PromptGenerator prompts = new PromptGenerator();

       // Get random prompts and response
       string prompts = prompts.GetRandomPrompt();
       string response = GetUserResponse();

       // Create entry
       Entry entry = new Entry(prompts, response, DateTime.Now);

       // Add entry to journal
       journal.AddEntry(entry);
     
    }
}