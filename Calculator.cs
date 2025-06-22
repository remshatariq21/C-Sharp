using System;

public class AddSubtract
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}

public class MultiplyDivide : AddSubtract
{
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }
}

public class Calculator : MultiplyDivide
{
    public void Calculate()
    {
        Console.WriteLine("Addition Result: " + Add(10, 5));
        Console.WriteLine("Subtraction Result: " + Subtract(10, 5));
        Console.WriteLine("Multiplication Result: " + Multiply(10, 5));
        Console.WriteLine("Division Result: " + Divide(10, 5));
    }
}


class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        calc.Calculate();
    }
}

