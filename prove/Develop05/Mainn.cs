using System;
using System.IO;

public class Mainn {

    // string _userName
    // public void setUserName(string name) {_userName = name;}
    // public void greatings() {}
    
    // private List<Goals> Goalss = new List<Goals>(); // NO WAY ---- IF THIS WORKS IT CHAINGES EVERYTHING ... no it does not because making a new instances of a class requires namespace DynamicCreateInstanceofclass and i dont know how to do that properly

    private List<string> MainnList = new List<string>();
    private string _points = "0";

    public void addPoints(double points) 
    {
        double P = double.Parse(_points);
        P =+ points;
        _points =  P.ToString("n2");   
    }

    public int getlistcount() {return MainnList.Count();}

    public void setMainnlist (List<string> list) 
    {
        MainnList.Clear();
        foreach (string line in list) {MainnList.Add(line);}
        _points = MainnList[0];
        MainnList.RemoveAt(0);
    }
    public List<string> giveListToFileWorker() // this is to give to fileWorker
    {
        MainnList.Insert(0, _points);
        return MainnList;
    }
    public List<string> giveWordsToGoals(int index) 
    {
        List<string> words = MainnList[index].Split("|").ToList();
        return words;
    } 
    public void addToMainnlist (string list) 
    {
        MainnList.Add(list);
    } 


    public string displayOptions(){
        Console.WriteLine($"You have {_points} points");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Creat new Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Gaosl");
        Console.WriteLine("  5. Record Gaol");
        Console.WriteLine("  6. Quit");
        Console.Write("Pick a choice form the menu: ");
        string choice = Console.ReadLine();
        Console.WriteLine("");
        return choice;
    }
    public string GoalCreationOptions()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. cheacklist Goal");
        Console.Write("witch type of goal would you like to creat: ");
        string choice = Console.ReadLine();
        Console.WriteLine("");
        return choice;
    }      
    public int recordChoice() 
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i <= MainnList.Count(); i++)
        {
            List<string> words = MainnList[i].Split("|").ToList();
            Console.WriteLine($"{i}. {words[1]}");
        }

        string choice = Console.ReadLine();
        return int.Parse(choice);
    } 
    public void DisplayGoals()
    {
        if (MainnList.Count() > 0) 
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i <= MainnList.Count(); i++)
            {
                List<string> words = MainnList[i].Split("|").ToList();
                Console.WriteLine($"{i}. {words[words.Count()-1]}");
            }
        }
        else {Console.WriteLine("you have no goals made yet");}
    }
}