using System.IO; 
using System.Collections.Generic;


class Program
{ 
    static void Main(string[] args) {
    
    Commun Commun = new Commun();
    Prompts Prompts = new Prompts();
    // MakeFlie makeFile = new MakeFlie();
    Read Read = new Read();
    WriteInFile WriteInFile = new WriteInFile();
    TempStorage TempStorage = new TempStorage();
    // all my classes
    List<string> TStoreg = new List<string>();
    // TEMP list
    List<string> prompts = new List<string>() 
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?", 
    "if you could say something to someone before you die what would it be", 
    "what would you like to accomplish today"};

    Commun.welcome();
    bool on = true;
    do 
    {   
        
        Commun.options();
        string choice = Commun.choice(); 

        if (choice == "1") // To Write in temp storage
        {
           string promp = Prompts.gitPrompt(prompts);
           Console.Write(">");
           string entries = Console.ReadLine();
           TempStorage.writeInTemp(promp, entries, TStoreg);
        }  

        else if (choice == "2") // To Display texts in timp storage
        {Read.CheckAndRead(TStoreg);}

        else if (choice == "3") // To load texts on list
        { 
            string goodJornal = choosFile();
            Read.Load_file(goodJornal, TStoreg);
        }
        else if (choice == "4") // To save in a journal
        {
            WriteInFile.writingString(TStoreg);
        }
        else if (choice == "5") 
        {
            WriteInFile.writeInTEMP(TStoreg);
            Commun.appEnd(); 
            on = false;
        }
        else {Console.WriteLine("Invalid input");}

    } while (on == true);



















// funtions

    static string choosFile()
    {
        Console.WriteLine("Journal name");
        string file = Console.ReadLine();
        if (File.Exists(file)) {return file;}
        else {return "bad";}
    }

}
}