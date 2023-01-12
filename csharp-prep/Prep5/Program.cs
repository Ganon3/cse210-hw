using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber() 
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
             int number = int.Parse(num);
            return number;
        }
        
        static int SquareNumber(int number) 
        {return number * number;}

        static void DisplayResult( string name, int number)
        {Console.WriteLine($"{name}, the square of your number is {number}");}

        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the Program!"); 
            DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
        }
        
        DisplayWelcome();
    }

}