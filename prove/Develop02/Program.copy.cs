using System.IO; 
using System.Collections.Generic;

// this place hold all funtions
class Program 
{
static string validation_method( string loop, string answer) // this is work with the do while loop in the options 1 threw 6
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
