using System;

class Program
{
  
    const int constantValue = 10;

 
    readonly int readonlyValue;

    public Program()
    {
      
        readonlyValue = 20;
    }

    static void Main()
    {
      
        Program program = new Program();

        Console.WriteLine("Constant Value: " + constantValue);
        Console.WriteLine("Readonly Value: " + program.readonlyValue);

       
    }
}
