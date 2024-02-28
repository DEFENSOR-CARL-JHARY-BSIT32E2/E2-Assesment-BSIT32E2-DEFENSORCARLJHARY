using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Fill the array with values based on user-defined formula (n^2)
        for (int i = 0; i < numbers.Length; i++)
        {
            int n = i + 1; // n starts from 1
            numbers[i] = n * n;
        }

        // Print the array
        Console.WriteLine("Array values:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Find the largest element in the array
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Print the largest element
        Console.WriteLine($"The largest element in the array is: {max}");

        Console.ReadLine(); // Keeps the console window open until a key is pressed
    }
}
