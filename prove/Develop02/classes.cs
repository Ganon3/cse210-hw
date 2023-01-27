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
        Console.WriteLine("Any unsaved text have been stored to temperary storage");
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
        string promp = {_prompts[randon_number];
        Console.WriteLine($"- {promp}. Press enter to finish");
        return promp;
    }
    

    // this ^ is for providing promps - BY David Daniel Punch my team mate
}   
public class MakeFlie {

    public void make_file(string _filename)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {outputFile.WriteLine($"You are in jernal - {_myfile}.");}
    }
}
public class ReadFile {
    string _jernal;

    public void read_file(string _jernal){

        string[] lines = System.IO.File.ReadAllLines(_jernal);
        foreach (string line in lines) {System.Console.WriteLine(line);}
    }

    /*
    public void git_file(){

    }
    */
    
}
public class WriteInFile {
    public string _jernal; 
    public string _enteryText;
    public void writingString(string promptt,string _entryText){

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        using (StreamWriter archivo = File.AppendText(_jernal!))
        {
            archivo.Write($"{dateText}: ");
            archivo.WriteLine($"{Promptt}");
            archivo.WriteLine($"{entryText}");
        }
    }
}   
public class TempStorage {
    List<string> tempStoreg = new List<string>();

    public writeInTemp(string promp, string entry)
    {
        tempStoreg.Add(promp);
        tempStoreg.Add(entry);
        tempStoreg.Add("");
         
    }
} 


/*
public class Read_and_Write{
    public string? _myfile;
    public string _writed_entry = "";
    
    public void for_reading_the_file()
    {
        foreach (string line in System.IO.File.ReadLines(_myfile!))
        {  
            System.Console.WriteLine(line);  
        }  
    }
    public void creating_a_file()
    {
        using (StreamWriter outputFile = new StreamWriter(_myfile!))
        {
            outputFile.WriteLine($"--------------------{_myfile}--------------------");
        }
    } 
    public void writing_on_file(string rando_pharase, string dateText)
    {
        using (StreamWriter archivo = File.AppendText(_myfile!))
        {
            archivo.WriteLine($"{_writed_entry}");
        }
    }
}   // this ^ is for reading and writing from a unique entry - BY David Daniel Punch my team mate
*/