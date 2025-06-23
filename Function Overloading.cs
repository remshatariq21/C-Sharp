using System;

class Program
{
    // Function with one int parameter
    static void Print(int number)
    {
        Console.WriteLine("Printing int: " + number);
    }

    // Overloaded function with one double parameter
    static void Print(double number)
    {
        Console.WriteLine("Printing double: " + number);
    }

    // Overloaded function with two int parameters
    static void Print(int a, int b)
    {
        Console.WriteLine("Printing two ints: " + a + " and " + b);
    }

    static void Main()
    {
        Print(5);         // Calls Print(int)
        Print(3.14);      // Calls Print(double)
        Print(10, 20);    // Calls Print(int, int)
    }
}
