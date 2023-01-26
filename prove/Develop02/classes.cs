using System;

public class Prompts {
    List<string> _different_Prompts = new List<string>() 
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?", 
    "if you could say something to someone before you die what would it be", 
    "what would you like to accomplish today"};
    
    public string randon_prompts()
    {
        Random randon_selector = new Random();
        int randon_number = randon_selector.Next(_different_Prompts.Count);
        string randon_promp = _different_Prompts[randon_number];
        return randon_promp;
    }
}   // this ^ is for providing promps - BY David Daniel Punch my team mate

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