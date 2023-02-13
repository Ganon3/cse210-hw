using System;

class Program
{
    static void Main(string[] args)
    {
       
       bool app_on = true;
       do {
        Console.WriteLine("cool beans");
        string word = Console.ReadLine();
        
        if (word == "quit") {app_on = false;}

       } while (app_on == true);

    }
}