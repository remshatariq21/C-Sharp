using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int d = 50;

        int maxvalue = Math.Max(Math.Max(a, b), Math.Max(c, d));
        int minvalue = Math.Min(Math.Min(a, b), Math.Min(c, d));

        Console.WriteLine("Maxvalue: " + maxvalue);
        Console.WriteLine("Minvalue: " + minvalue);
    }
}
