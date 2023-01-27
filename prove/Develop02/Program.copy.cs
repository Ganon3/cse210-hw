using System.IO; 
using System.Collections.Generic;
class Program 
{   // this place hold all funtions
   
   static string checkChoice(string choice) 
   {
    string on = "on";
    do{
        if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
        {
            return choice;
            on = "off";
        }

        else 
        {
            Console.WriteLine("Invalid input");
            choice = Console.ReadLine();
        }

    } while (on = "off");
   }
   
   
   
   
   static string Do_while(string loop, string answer) // this is work with the do while loop in the options 1 threw 6
    {
        if (answer == "n") 
            {
            Console.WriteLine("Do you want to do something else?: ");
            loop = "no";
            return loop;
            } 
        else
            {
            Console.WriteLine("Invalid input, please asnwer with the letter (y) or (n) to coninute.");
            Console.WriteLine("");
            return loop;
            }    
    }
}
