using System;
using System.IO; 

public class Commun {

    /*
    string name;
    string lastname;
    */
    
    public static void welcome() 
    {
        Console.WriteLine("");
        Console.WriteLine("Jornal App");
        Console.WriteLine("Thank You for using our app");
       
    } 
    public static void options()
    {
        Console.WriteLine("");
        Console.WriteLine("Options Bellow");
        Console.WriteLine("1._ Write");
        Console.WriteLine("2._ Display");
        Console.WriteLine("3._ Load");
        Console.WriteLine("4._ Save");
        Console.WriteLine("5._ Quit");
    }

    public static void appEnd() 
    {
        Console.WriteLine("");
        Console.WriteLine("Any unsaved entries have ben added to TEMP.text");
        Console.WriteLine("Thank you for choosing Jornal App :)");
    }

    public static string choice()
    {   
        string choice = Console.ReadLine();
        return choice;
    }
    
    
}

public class Prompts {
    
    public static string gitPrompt(List<string> list)
    {
        Random randon_selector = new Random();
        int randon_number = randon_selector.Next(list.Count);
        string promp = list[randon_number];
        Console.WriteLine($"- {promp}. Press enter to finish");
        return promp;
    }
    // this ^ is for providing promps - BY David Daniel Punch my team mate
}   

public class Read {
    // string _jernal;

    /*
    public void read_file(string journal){

        string[] lines = System.IO.File.ReadAllLines(journal);
        foreach (string line in lines) {System.Console.WriteLine(line);}
    }
    */

    public static void CheckAndRead(List<string> list) {

        if (list.Count < 1) { Console.WriteLine("There are no entry yet.");}
        else 
        {
            Console.WriteLine("----VVV----");
            Console.WriteLine("Your entries are:");
            foreach (string line in list)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("---^^^---");
        }
    }

    public static void Load_file(string goodJornal, List<string> list)
    {
        if (goodJornal == "bad") 
        {
            Console.WriteLine("");
            Console.WriteLine("This Journal does not exsist yet");
            Console.WriteLine("Please use the save option to make a jurnal");
            Console.WriteLine("Remimber it must be a .text file");
        }    
        else 
        {   
            string[] lines = System.IO.File.ReadAllLines(goodJornal);
            foreach (string line in lines) {list.Add(line);} 
        }   
    }   
    

    /*
    public void git_file(){

    }
    */
    
}

public class WriteInFile {
    //public string _jernal; 

    public static void writingString(List<string> list){

        Console.WriteLine("");
        Console.WriteLine("What is the journal name");
        Console.WriteLine("will override exsisting journal");
        Console.Write(">");
        string jornalName = Console.ReadLine();

        using (StreamWriter outputFile = File.AppendText(jornalName))
        {
            outputFile.WriteLine($"You are in jornal - {jornalName}.");
            foreach (string line in list) {outputFile.WriteLine(line);}
            list.Clear();
        }
    }

    public static void writeInTEMP(List<string> list)
    {
        using (StreamWriter outputFile = File.AppendText("TEMP.text"))
        {
            foreach (string line in list) {outputFile.WriteLine(line);}
            list.Clear();
        }
    }
}   

public class TempStorage {
    
    public static void writeInTemp(string promp, string entry, List<string> list)
    {   
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    
        list.Add($"{dateText} - {promp}");
        list.Add(entry);
        list.Add("");
         
    }
} 
