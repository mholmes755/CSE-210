using System;

class Program
{
    static void Main(string[] args)
    {
    // Ask for grade and store as a variable
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        
    // Change string variable to an integer variable
        int number = int.Parse(grade);

        if (number >= 90) 
        {Console.WriteLine("You have an A in the class. ");}

        else if (number >= 80 && number <90)
        {Console.WriteLine("You have a B in the class. ");}

        else if (number >= 70 && number <80)
        {Console.WriteLine("You have a C in the class. ");}

        else if (number >= 60 && number <70)
        {Console.WriteLine("You have a D in the class. ");}

        else if (number <60)
        {Console.WriteLine("You have an F in the class. ");}

        
    }
}