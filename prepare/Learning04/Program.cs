using System;

class Program
{
    static void Main(string[] args)
    {
        // New instance of the Assignment class with a name and subject as arguments
        Assignment assignment = new Assignment("Michael Holmes", "CSE 210");

        // Call the GetSummary method to print what was input above ^
        Console.WriteLine(assignment.GetSummary());

        MathAssignment homework = new MathAssignment("Anna Holmes", "Fractions", "Section 7.3", "Problems 12-25");
        Console.WriteLine(homework.GetSummary());
        Console.WriteLine(homework.GetHomeworkList());

        WritingAssignment essay = new WritingAssignment("Norbert Ridgeback", "Environmental Science", "Mountains of Brazil");
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInfo());
    }
}