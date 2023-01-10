using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string percent = Console.ReadLine();
        int num = int.Parse(percent);
        Boolean letter = true;

        // num holds the percent now 

        if (num >= 90) {Console.WriteLine("You got an A."); letter = true;}
        else if (num >= 80) {Console.WriteLine("You got an B."); letter = true;}
        else if (num >= 70) {Console.WriteLine("You got an C."); letter = true;}
        else if (num >= 60) {Console.WriteLine("You got an D."); letter = false;}
        else if (num <  60) {Console.WriteLine("You got an F."); letter = false;}

        if (letter) {Console.Write("HURAY!!! you passed.");}
        else {Console.Write("Sorry, you faild.");}
       

    }
}