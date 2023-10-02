using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";

        Console.WriteLine("Welcome to the scriptre memorizer!");
        Console.WriteLine("The reference and verses will soon populate the console. To continue press enter.");
        Console.WriteLine("When the scripture appears, simply press enter to eliminate some of the words.");
        Console.WriteLine("This will continue until all words are gone or until you type 'quit'.");
        Console.WriteLine("If either of these 2 conditions occur, then the program will end. Press the return key to continue. ");
        Console.ReadLine();
        
        // Make new instance of the Reference constuctor and pass in Scripture reference
        Reference Reference1 = new Reference("Proverbs", 3, 5, 6);

        // Make a new instance of the Scripture reference and pass in the Reference instance just created and the scripture desired
        Scripture Scripture = new Scripture(Reference1, "Trust in the Lord with all thine heart and lean not unto thy own understanding; in all they ways acknowledge him, and he shall direct thy paths.");
        
        
        // Let the memorizing begin. Let the program take words away each time the user hits enter with the While loop
        while (true)
        {
        //Call the HideRandomWords function to hide random words


            Console.WriteLine(Scripture.GetDisplayText());
            if (Scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congrats! You've memorized the scripture!");
                break;
            }

            response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                Console.WriteLine("You've quot the program.");
                break;
            }
            Scripture.HideRandomWords(1);
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
        

    }
}