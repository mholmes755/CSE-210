using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator myPrompts = new PromptGenerator();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write
                    string prompt = myPrompts.GetRandomPrompt();
                    Console.WriteLine("Write about the following prompt:");
                    Console.WriteLine(prompt);
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        PromptText = prompt,
                        EntryText = entryText
                    };

                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully.");
                    break;

                case "2":
                    // Display
                    Console.WriteLine("Displaying all entries:");
                    myJournal.DisplayAll();
                    break;

                case "3":
                    // Load
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    // Save
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;

                case "5":
                    // Quit
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}