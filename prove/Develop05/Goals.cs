using System;
using System.IO;

abstract class Goals 
{

    /*
    string _name = "name";
    string _info = "info";
    string _reword = "0";
    string _acomplished = "false";
    */
    

    protected List<string> InfoList = new List<string>() {"","","","0","F","0","0","0",""}; // {"type of Goal","name","info","0","F","Display Info"};
    protected List<string> InfoListReset = new List<string>() {"","","","0","F","0","0","0",""};
    
    public void setName(string name) {InfoList[1] = name;}
    public void setinfo(string info) {InfoList[2] = info;}
    public void setReword(string reword) {InfoList[3] = reword;}
    public void reSetList(List<string> list) 
    {
        InfoList.Clear();
        foreach (string word in list) {InfoList.Add(word);}
    } 

    public abstract void setGoalType();
    protected abstract void setAcomplished();
    public abstract void setDisplay();
    
    // ubove is for making new instance of a Goal

    protected abstract double getReword(); // example: {return double.Parse(InfoList[3]);} 
    public abstract double recodEvent(); // directly effect true or falls; any other tracking in the list
   
    public string GiveStringToMainn() 
    {
        string info = string.Join("|", InfoList);
        InfoList.Clear();
        foreach (string item in InfoListReset) {InfoList.Add(item);}
        return info;
    }
}

public class SimpleGoal : Goals 
{
    public override void setGoalType() {InfoList[0] = "SG";}
    protected override void setAcomplished() {InfoList[4] = "T";}
    public override void setDisplay()
    {
        if (InfoList[4] == "T") {InfoList[InfoList.Count()-1]= $"[X] {InfoList[1]} ({InfoList[2]})";}
        else if (InfoList[4] == "F") {InfoList[InfoList.Count()-1]= $"[] {InfoList[1]} ({InfoList[2]})";}
    }

   
    protected override double getReword() {return double.Parse(InfoList[3]);} 
    public override double recodEvent() 
    {
        
        setAcomplished();
        setDisplay();
        return getReword();
    }

}

public class EternalGoal : Goals 
{
    public override void setGoalType() {InfoList[0] = "EG";}
    protected override void setAcomplished() 
    {
        if (InfoList[4] == "F") {InfoList[4] = "1";}
        else if (InfoList[4] != "F") 
        {
            int number = int.Parse(InfoList[4]);
            number += 1;
            InfoList[4] = number.ToString();
        }
    }
    public override void setDisplay() {InfoList[InfoList.Count()-1]= $"[] {InfoList[1]} ({InfoList[2]})";}
    protected override double getReword() {return double.Parse(InfoList[3]);} 
    public override double recodEvent() 
    {
        setDisplay();
        setAcomplished();
        return getReword();
    }
}

public class CheckListGoal : Goals 
{
    public void setBonus(string bounus) {InfoList[5] = bounus;}
    public void setHowManyTimes(string top) {InfoList[6] = top;}
    public override void setGoalType() {InfoList[0] = "CG";}
    protected override void setAcomplished() 
    {
        int top = int.Parse(InfoList[6]);
        int bot = int.Parse(InfoList[7]);

        if (top <= bot) {InfoList[4] = "T";}
        else if (top >= bot) {bot += 1;}

        InfoList[7] = bot.ToString();
    }
    public override void setDisplay()
    {
        if (InfoList[4] == "T") {InfoList[InfoList.Count()-1]= $"[X] {InfoList[1]} ({InfoList[2]}) -- {InfoList[7]}/{InfoList[6]}";}
        else if (InfoList[4] == "F") {InfoList[InfoList.Count()-1]= $"[] {InfoList[1]} ({InfoList[2]}) -- {InfoList[7]}/{InfoList[6]}";}
    }

   
    protected override double getReword() 
    {
        double amount = 0;
        if (InfoList[4] == "F") {amount = double.Parse(InfoList[3]);}
        if (InfoList[4] == "T") {amount = double.Parse(InfoList[3]) + double.Parse(InfoList[5]);}
        return amount;
    } 
    public override double recodEvent() 
    {
        setDisplay();
        setAcomplished();
        return getReword();
    }

}



