using System;

class Program
{
    static void Main(string[] args)
    {
        // Iterate from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            // Calculate square root
            double squareRoot = Math.Sqrt(i);

            // Print the number along with its square root
            Console.WriteLine($"Number: {i}, Square Root: {squareRoot}");
        }

        Console.ReadLine(); // Keeps the console window open until a key is pressed
    }
}
