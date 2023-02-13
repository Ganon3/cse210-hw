using System;
using System.IO;
using System.Collections.Generic;

public class StringToList {

    private string _scrip = "";
    
    private List<string> ScripList = new List<string>();
    public StringToList(string scrip) {_scrip = scrip;}
    public StringToList() {_scrip = "This is a test, click enter to clear the words in this centince.";}
    public List<string> ConvertToList() {

        List<string> words = new List<string>(_scrip.Split(" "));
        return words;
        }

}

public class BlankOutList {

    private List<string> blankList = new List<string>();

    public void getList(List<string> list) {

        foreach (string word in list) {blankList.Add(word);}

    }

    public void blankIt(){

        int clearAm = 3;
        bool appON = true;
        
        while (appON) {  
            
            if (checkLits(blankList)) {
                
                for (int word = 0; word < blankList.Count(); word++){
                    
                    Random rd = new Random();
                    int rand = rd.Next(0,5);
                    
                    if (rand == 4 && blankList[word] != "___"){

                    /* 
                    string[] itemm = words[word].Split();
                    for (int i = 0; i < itemm.Count(); i++) {
                    itemm[i] = "_";
                    }
                    string newString = string.Join(" ", itemm);
                    Console.WriteLine(newString);

                    // i could not get it to work but you see what i wanted
                    */

                    blankList[word] = "___";
                    if (clearAm > 0) {clearAm -= 1;}
                    else {appON = false;}
                    }
                }   
            }
            else if (checkLits(blankList) == false) {break;}
        }
    }

    public bool checkLits(List<string> list) {
        int count = 0;
        bool good = false;
        foreach (string word in list) {
            if (word == "___") {count += 1;}
            }
            
        if (count < list.Count()) {good = true;}
        else if (count >= list.Count()) {good = false;}
        return good;
    }

    public List<string> GiveList() {
        return blankList;
        }
}
public class Display {
    public List<string> displayList = new List<string>();

    private string _scripInfo;

    public Display() {_scripInfo = "Scripture - ";}
    public Display(string scripInfo) {_scripInfo = scripInfo;}

    public void getList(List<string> list) {

        displayList.Clear();
        foreach (string word in list) {displayList.Add(word);}

    }

    public void display() {
        
        Console.Write(_scripInfo);
        foreach (string word in displayList) {Console.Write($"{word} ");}
        Console.WriteLine("");

    } 
}