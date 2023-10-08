using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

while (answer != "4")
{
        Console.WriteLine("Welcome to the Mindfullness Program! Please select an option from the Menu below by typing the number beside the option you wish to choose: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");
        answer = Console.ReadLine();

    // If user selects "Breathing Activity" the program follows this route
            if (answer == "1")
            {
                BreathingActivity _breathing = new BreathingActivity();
                Console.WriteLine(_breathing.DisplayStartingMessage());
                
                // Set time limit for how long activity will last
                Console.WriteLine("How long would you like for this activity to run? ex. '30' will be 30 seconds. ");
                int timeAnswer = int.Parse(Console.ReadLine());

        // Display Get Ready message
            Console.Write("Get Ready... ");
            Activity activity = new Activity();
            activity.ShowCountDown(5);


            DateTime startTime = DateTime.Now;
            DateTime endtime = startTime.AddSeconds(timeAnswer);
    //Loop this as long as the timer that the user selects**
        while (DateTime.Now < endtime)
        {
                // Display Breathing Message
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breath in... ");
            // Countdown
            activity.ShowCountDown(4);


        //Display Hold Your Breath Message
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Hold your breath... ");
            //CountDown
            activity.ShowCountDown(4);


        //Display Breath Out Message
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breath Out... ");
            // CountDown
            activity.ShowCountDown(8);
        }
            Console.WriteLine();
            Console.WriteLine($"Congratulations. You've completed {timeAnswer} seconds of the Breathing Activity!");
            Console.WriteLine(_breathing.DisplayEndingMessage());
            Thread.Sleep(5000);
            Console.Clear();
            }
        
    // If user selects "Listing Activity" the program follows this route
            else if (answer == "2")
            {
                ListingActvity listing = new ListingActvity();
                Console.WriteLine(listing.DisplayStartingMessage());
                Console.WriteLine();

            // Select Time Duration for the Activity
                Console.WriteLine("How long would you like for this activity to run? ex. '30' will be 30 seconds. ");
                int timeAnswer = int.Parse(Console.ReadLine());


        // Display Get Ready message
            Console.Clear();
            Console.Write("Get Ready... ");
            // Display "spinner"
            Activity activity = new Activity();
            activity.ShowSpinner(8);

            Console.WriteLine();
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            Console.WriteLine(listing.GetRandomPrompt());
            Console.WriteLine("Hit Enter to Continue");
            Console.ReadLine();
            Console.Write("You may begin in ");
            activity.ShowCountDown(5);
            Console.WriteLine();
            Console.Clear();
            //Set Activity within Time Limit
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(timeAnswer);
            while (DateTime.Now < endTime)
            {
                Console.Write(">");
                Console.ReadLine();

            }
            Thread.Sleep(3000);
            Console.WriteLine($"Congratulations! You've completed {timeAnswer} seconds of the Listing Activity");
            Console.WriteLine(listing.DisplayEndingMessage());
            Thread.Sleep(5000);
            Console.Clear();

            }

    // If user selects "Reflecting Activity" the program follows this route
            else if (answer == "3")
            {
                ReflectingActivity reflection = new ReflectingActivity();
                Console.WriteLine(reflection.DisplayStartingMessage());

            // Get time Duration
                Console.WriteLine("How long would you like for this activity to run? ex. '30' will be 30 seconds. ");
                int timeAnswer = int.Parse(Console.ReadLine());
            

    // Display Get Ready message
            Console.Write("Get Ready... ");
    // Display "spinner"
            Activity activity = new Activity();
            activity.ShowSpinner(8);

            Console.WriteLine();
            Console.WriteLine("Consider the Following Prompt: ");
            Console.WriteLine();
        // Get Random Prompt and Display it
            string prompt = reflection.GetRandomPrompt();
            reflection.DisplayPrompt();

            Console.WriteLine("When you have something in mind, hit enter. ");
            Console.ReadLine();
            Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            activity.ShowCountDown(5);
            Console.Clear();
            

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(timeAnswer);

            while (DateTime.Now < endTime)
            {
                reflection.GetRandomQuestion();
                reflection.DisplayQuestion();
                activity.ShowSpinner(10);
            }
            Console.WriteLine($"Congratulations! You've completed {timeAnswer} seconds of the Reflection Activity!");
            Console.WriteLine(reflection.DisplayEndingMessage());
            Thread.Sleep(5000);
            Console.Clear();
            }
            
            else if (answer == "4")
            {
                Console.Clear();
                Console.WriteLine("End Program");
            }
    }
    }
    }















    // Edit Ending Messages for all Activities and Put Activities into a While Loop