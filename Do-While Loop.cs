using System;

class Program
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine("Number: " + i);
            i++;
        }
        while (i <= 5);

        Console.WriteLine("Loop ended.");
    }
}

