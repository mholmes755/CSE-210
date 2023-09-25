using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> Prompts { get; private set; }

    public PromptGenerator()
    {
        Prompts = new List<string>();
    }

    public string GetRandomPrompt()
    {
        if (Prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int randomIndex = random.Next(0, Prompts.Count);
        return Prompts[randomIndex];
    }
}