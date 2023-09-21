using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
    // Find a random # between 1 and 11
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        int guess = -1;
        while (guess != magicNumber)
        {   Console.Write("Guess a number between 1 and 11: ");
            guess = int.Parse(Console.ReadLine());

        // Start conditionals to see if they guessed it right
            if (guess != magicNumber)
                if (guess > magicNumber)
                {Console.WriteLine("Guess a little lower. ");}
                else if (guess < magicNumber)
                {Console.WriteLine("Guess a little higher ");}
        } Console.WriteLine("That's Correct! ");
    }
}
