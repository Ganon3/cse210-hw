using System;
using System.IO; 

public class Mainn {
    /*
    string name;
    string lastname;
    */
     
    
    public welcome() 
    {
        Console.WriteLine("Jornal App");
        console.WriteLine("Thank You for using our app");
       
    } 
    public optionss()
    {
        Console.WriteLine("Options Bellow");
        Console.WriteLine("1._ Write");
        Console.WriteLine("2._ Display");
        Console.WriteLine("3._ Load");
        Console.WriteLine("4._ Save");
        Console.WriteLine("5._ Quit");
    }

    public appEnd() 
    {
        Console.WriteLine("Any unsaved entries have ben added to TEMP.text");
        Console.WriteLine("Thank you for choosing Jornal App :)");
    }

    public string choice()
    {
        string choice = Console.ReadLine();
        return choice;
    }
    
    
}

public class Prompts {
    List<string> _prompts = new List<string>() 
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?", 
    "if you could say something to someone before you die what would it be", 
    "what would you like to accomplish today"};
    
    public string gitPrompt()
    {
        Random randon_selector = new Random();
        int randon_number = randon_selector.Next(_prompts.Count);
        string promp = _prompts[randon_number];
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

    public void CheckAndRead(string filee) {

        if (file.count < 1) { Console.WriteLine("There are no entry yet.");}
        else 
        {
            Console.WriteLine("Your entries are:")
            foreach (string line in filee)
            {
                Console.WriteLine(line);
            }
        }
    }

    public Load_file(string goodJornal, string list)
    {
        if (goodJornal == "bad") 
        {
            console.WriteLine("This Journal does not exsist yet");
            console.WriteLine("Please use the save option to make a jurnal");   
        }    
        else 
        {   
            list.Clear()
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines) {list.Add(linee);}  
        } 
    }   
    

    /*
    public void git_file(){

    }
    */
    
}

public class WriteInFile {
    //public string _jernal; 

    public void writingString(string list){

        Console.WriteLine("What is the journal name");
        Console.WriteLine("will override exsisting journal");
        Console.Write(">");
        string jornalName = Console.ReadLine();

        using (StreamWriter outputFile = File.AppendText(jornalName))
        {
            outputFile.WriteLine($"You are in jornal - {jornalName}.");
            foreach (string line in list) {outputFile.WriteLine(line)}
            list.Clear()
        }
    }

    public void writeInTEMP(string line)
    {
        using (StreamWriter outputFile = File.AppendText("TEMP.text"))
        {
            foreach (string line in list) {outputFile.WriteLine(line)}
            list.Clear()
        }
    }
}   

public class TempStorage {
    List<string> TStoreg = new List<string>();
    
    
    public writeInTemp(string promp, string entry)
    {   
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    
        TStoreg.Add($"{dateText} - {promp}");
        TStoreg.Add(entry);
        TStoreg.Add("");
         
    }
} 

/*
public class MakeFlie {

    public void make_file(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"You are in jornal - {filename}.");
        }
    }
}
*/
