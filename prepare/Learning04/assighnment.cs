using System;

public class Assignment {

    protected string _studentName = "Unknown";
    protected string _topic = "Not given";

    public Assignment(string studentName, string topic) 
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    public string getSummary() 
    {
        return $"name: {_studentName} - topic: {_topic}";
    }
}

public class MathAssignment : Assignment {

    private string _textBookSection = "Unknown";
    private string _problems = "Not given";

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic) 
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        
        string info = base.getSummary();
        return $"{info} - section: {_textBookSection} - problems: {_problems}.";
    }
}

public class WirtingAssignment : Assignment {

    private string _title = "Unkown";

    public WirtingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfomation() {
        
        string info = base.getSummary();
        return $"{info} - title: {_title}";
    }
}