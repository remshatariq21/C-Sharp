using System;

class Printer
{
    // Print a string message
    public void Print(string message)
    {
        Console.WriteLine("String message: " + message);
    }

    // Print an integer message
    public void Print(int number)
    {
        Console.WriteLine("Integer number: " + number);
    }

    // Print a string message multiple times
    public void Print(string message, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        printer.Print("Hello, World!");   // Calls Print(string)
        printer.Print(100);                // Calls Print(int)
        printer.Print("Repeat this", 3);  // Calls Print(string, int)
    }
}

