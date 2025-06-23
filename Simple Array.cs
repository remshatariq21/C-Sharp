using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an array
        int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

        // Print the array elements
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }
    }
}
