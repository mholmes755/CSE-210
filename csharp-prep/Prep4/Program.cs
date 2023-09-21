using System;
using System.ComponentModel;
using System.Globalization;

List<int> numbers = new List<int>();
int number = 1;
Console.WriteLine("In this program we will create a list of numbers. Please enter various numbers. When you are ready to stop, input the number 0.");
while (number != 0)
{
    Console.WriteLine("Enter a number: ");
    number = int.Parse(Console.ReadLine());
    numbers.Add(number);
}
int sum = 0;
double avg = 0.0;
int largest = -1000;
foreach (int num in numbers)
{
    sum += num;
    avg = (double)sum / numbers.Count;
    if (num > largest)
    {
        largest = num;
    }
}
// Output of sum, largest number, and entire list
Console.WriteLine("List of Numbers: ");
foreach (int num in numbers)
{ Console.WriteLine(num); }
Console.WriteLine($"The Sum is: {sum} ");
Console.WriteLine($"The Average is: {avg:F2} ");
Console.WriteLine($"The largest number is: {largest} ");
