using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int Mnum = int.Parse(magicNumber);
        int Gnum = 0;

        while (Gnum != Mnum) 
        {   
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            Gnum = int.Parse(guessNumber);

            if (Gnum > Mnum) {Console.WriteLine("Lower");}
            else if (Gnum < Mnum) {Console.WriteLine("Higher");}
            else {Console.WriteLine("You guessed it!");}
        }
    }
}