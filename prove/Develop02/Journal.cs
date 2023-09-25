using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in Entries)
                {
                    writer.WriteLine($"Date: {entry.Date}");
                    writer.WriteLine($"Prompt: {entry.PromptText}");
                    writer.WriteLine($"Entry Text: {entry.EntryText}");
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal to file: {e.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                Entries.Clear(); // Clear existing entries
                Entry currentEntry = null;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line.StartsWith("Date: "))
                    {
                        currentEntry = new Entry();
                        currentEntry.Date = line.Substring("Date: ".Length);
                    }
                    else if (line.StartsWith("Prompt: "))
                    {
                        currentEntry.PromptText = line.Substring("Prompt: ".Length);
                    }
                    else if (line.StartsWith("Entry Text: "))
                    {
                        currentEntry.EntryText = line.Substring("Entry Text: ".Length);
                        Entries.Add(currentEntry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal from file: {e.Message}");
        }
    }
}