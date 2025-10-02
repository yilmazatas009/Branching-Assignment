﻿namespace BranchingAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight is over the limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program
        }

        // Prompt user for package width
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt user for package height
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt user for package length
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program
        }

        // Calculate the shipping quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");

        // Ending message
        Console.WriteLine("Thank you!");
    }
}
