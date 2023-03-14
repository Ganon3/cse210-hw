using System;
using System.IO;

public class fileWorker 
{
    private List<string> fileInfo = new List<string>(); 
    private string _fileName;
    public void setFileName(string name) {_fileName = name;}
    
    public void setFromFile() 
    {
        fileInfo.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines) 
        {
            fileInfo.Add(line);
        }
    }

    public void setfromMainn(List<string> list) 
    {
        fileInfo.Clear();
        foreach (string items in list)
        {
            fileInfo.Add(items);
        }
    }

    public void saveFileInfo() 
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName)) 
        {
            foreach (string line in fileInfo) {outputFile.WriteLine($"{line},");}
        }
    }

    public List<string> shairFileInfo() 
    {
        return fileInfo;
    }
}