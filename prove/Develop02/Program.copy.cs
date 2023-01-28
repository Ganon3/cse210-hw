using System.IO; 
using System.Collections.Generic;

class Program 
{   // this place hold all funtions
   
   static string checkChoice(string choice) 
   {
        bool on;
        while (on) 
        {
            if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
            {
                on = false;
                return choice;
                
            }
            else 
            {
                Console.WriteLine("Invalid input");
                choice = Console.ReadLine();
                return "";
            }
        }
   }


    static string choosFile()
    {
        Console.WriteLine("Journal name");
        string file = Console.ReadLine();
        if (File.Exists(file)) {return file;}
        else {return "bad";}
    }
   
}
