using System;

class Program
{
    static void Main(string[] args)
    {
        double baseLength, height, area;

        // Prompt user for base length
        Console.Write("Enter the base length of the triangle: ");
        while (!double.TryParse(Console.ReadLine(), out baseLength) || baseLength <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Enter the base length of the triangle: ");
        }

        // Prompt user for height
        Console.Write("Enter the height of the triangle: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Enter the height of the triangle: ");
        }

        // Calculate area
        area = 0.5 * baseLength * height;

        // Display result
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

        Console.ReadLine(); // Keeps the console window open until a key is pressed
    }
}
