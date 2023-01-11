using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Time to play Guess MY Number");
        Random randomGenerator = new Random();
        int Mnum = randomGenerator.Next(1, 100);
        int Gnum = 0;
        int guesses = 0;
        string play = "yes";
    
        while (Gnum != Mnum) 
        {   
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            Gnum = int.Parse(guessNumber);
            guesses = guesses + 1;

            if (Gnum > Mnum) {Console.WriteLine("Lower");}
            else if (Gnum < Mnum) {Console.WriteLine("Higher");}
            else 
            { 
                Console.WriteLine("You guessed it!");
                guesses.ToString();
                Console.WriteLine($"it took you {guesses} tryes.");
            }
        }

        
    }
}