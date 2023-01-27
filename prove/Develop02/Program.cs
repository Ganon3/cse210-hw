using System.IO; 
using System.Collections.Generic;


class Program { static void Main(string[] args, string generate_random_prompts) {
    
    Mainn mainn = new Mainn();
    Prompts prompts = new Prompts();
    MakeFlie makeFile = new MakeFlie();
    ReadFile readFile = new ReadFile();
    WriteInFile writeFile = new WriteInFile();
    TempStorage tempStorage = new TempStorage();
    // all my classes

    Mainn.welcome();
    string app_on = "true";
    do 
    {
        Mainn.options;
        string choice = checkChoice(Mainn.choice()); 

        if (choice == 1) // To Write in temp storage
        {
           string promp = Prompts.gitPrompt();
           string entries = Console.ReadLine();
           TempStorage.writeInTemp(promp, entries);
           foreach (string line in TempStorage.tempStorage)
                        {
                        Console.WriteLine(line);
                        }
        
        }  
        else if (choice == 2) // To Display texts in timp storage or journal
        {}
        else if (choice == 3) // To load saved texts
        {}
        else if (choice == 4) // To save temp storage to journal
        {}
        else if (choice == 5) {Mainn.appEnd(); app_on = "false";}


   
    
        
    } while (app_on = "true");


}

