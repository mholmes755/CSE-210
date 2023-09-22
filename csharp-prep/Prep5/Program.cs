using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    // static string name;
    // static int number;
    // static int squared;
    static void Main(string[] args)
    {
        DisplayResult();
        

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine("");
            }

        static string PromptUserName()
        {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number  =  PromptUserNumber();
            int squared = SquareNumber(number);

            Console.WriteLine($"{name}, the square of your number is {squared}");
            
        }

    
}