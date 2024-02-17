using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text (type 'exit' to terminate):");

        string input;
        do
        {
            input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);
        } while (input != "exit");

        Console.WriteLine("Program terminated.");
    }
}
