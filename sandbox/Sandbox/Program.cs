using System;
using System.IO; 

class Program
{
    static void Main(string[] args) {

        
        List<string> words = new List<string>() {"cat", "dog", "hat", "frog", "fillup", "bill"};
        // Console.WriteLine(words[words.Count()-1]);
        /*
        string info = string.Join("|", words);
        Console.WriteLine(info);
    
        
        static int returnNuber() {return 4;}
        static int getNumber() {return returnNuber();}
        int OK = getNumber();
        */
         
        words[12] = "turtle";
        foreach (string item in words) {Console.Write($"{item} -- ok");}


        


    }
}