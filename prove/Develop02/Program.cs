using System.IO; 
using System.Collections.Generic;


class Program { static void Main(string[] args, string generate_random_prompts) {
    
    Mainn mainn = new Mainn();
    Prompts prompts = new Prompts();
    // MakeFlie makeFile = new MakeFlie();
    Read read = new Read();
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
           Console.Write(">");
           string entries = Console.ReadLine();
           TempStorage.writeInTemp(promp, entries);

        }  
        else if (choice == 2) // To Display texts in timp storage
        {Read.CheckAndRead(TempStorage.TStoreg);}

        else if (choice == 3) // To load texts on list
        { 
            string goodJornal = choosFile();
            Read.Load_file(goodJornal, TempStorage.STorage);
        }
        else if (choice == 4) // To save in a journal
        {
            WriteInFile.writingString(TempStorage.STorage);
        }
        else if (choice == 5) 
        {
            WriteInFile.writeInTRMP(TempStorage.STorage);
            Mainn.appEnd(); 
            app_on = "false";
        }

    } while (app_on = "true");
}