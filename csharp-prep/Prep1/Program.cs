using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your first name?");
        string firstN = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastN = Console.ReadLine();
        Console.WriteLine($"your name is, {firstN} {lastN}.");
    }
}