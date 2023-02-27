using System;

public class Mainn {

    private List<string> _countDownAni = new List<string>() {"5","4","3","2","1"};
   

    public string options(){

        Console.WriteLine($"Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    public void spinerAni(int seconds) {

        List<string> _spinerAni = new List<string>() {"-","\\","|","/","-"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now <= endTime) {
            foreach (string s in _spinerAni) {

                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

       
}



public class Activity {

    protected string _activityName = "";
    protected string _activityInfo = "";
    protected string _endMesseg = "";
    
    protected int _sessionTime = 0;
    protected void getSessionTime() {

        Console.Write("how long, in seconds, would you like to have for your session? ");
        _sessionTime = int.Parse(Console.ReadLine());
        
    }

    protected static void countDownAni(int seconds) {

        for (int i = seconds; i > 0; i--) {
    
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    protected static void spinerAni(int seconds) {

        List<string> _spinerAni = new List<string>() {"-","\\","|","/","-"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now <= endTime) {
            foreach (string s in _spinerAni) {

                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void display(string _activityname) {

        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine("");
        Console.WriteLine(_activityInfo);
        Console.WriteLine("");
        getSessionTime();
        Console.Clear();

    }

    public void runActivity() {

        Console.Write("Get ready ... ");
        Activity.spinerAni(5);
        Console.Clear();
    } 

    protected void endMesseg() {

        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Activity.spinerAni(4);
        Console.WriteLine("");
        _endMesseg = $"You have completed another {_sessionTime} seconds of the {_activityName}";
        Console.WriteLine(_endMesseg);
        Activity.spinerAni(4);
        Console.Clear();
        
    }
}





public class BreathingActivity : Activity {

    public void getInfo() {
        
        _activityName = "breathing activity";
        _activityInfo = "This activity will help you by walking through breathing in and out. Clear your mined and focus on your breathing";

    }

    public void display() {
        getInfo();
        base.display(_activityName);
    }

    public void RunActivity() {
        
        base.runActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_sessionTime);
        
        while (DateTime.Now <= endTime) {
            
            Console.Write("Breath In ... ");
            Activity.countDownAni(4);
            Console.WriteLine("");
            
    
            Console.Write("Breath out ... ");
            Activity.countDownAni(6);
            Console.WriteLine("");
        }

        base.endMesseg();

    } 
}

public class ReflectionActivity : Activity {

    private List<string> exsperiances = new List<string>() {"Think of a time when you did something really difficult.", "Think of a time when your family did something fun together; why was it fun?", "Think of a time when you where angry and how you solved that anger."};
    private List<string> questions = new List<string>() {"How did you feel when this experiance was complete?", "How did this experiance help you or other peopel around you?", "did this experinace bring you to be closer to your lord and how?", "what is your favorite thing about this experience?"};
    private void getInfo() {
        
        _activityName = "reflection activity";
        _activityInfo = "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recogmize the power you have and how you can use it in other aspects of yuor life.";
    }

    public void display() {
        getInfo();
        base.display(_activityName);
    }

    public void runActivity() {

        base.runActivity();

        Random randomSelect = new Random();
        int randNum1 = randomSelect.Next(exsperiances.Count);
        string prompt1 = exsperiances[randNum1];
        
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine("");
        Console.WriteLine($"--- {prompt1} ---");
        Console.WriteLine("");
        Console.WriteLine("When you got somthing in your mined click enter");
        Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--) {

                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.Clear();
        Console.WriteLine($"--- {prompt1} ---");
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_sessionTime);

        while (DateTime.Now <= endTime) {

            int randNum2 = randomSelect.Next(questions.Count);
            string prompt2 = questions[randNum2];
            Console.WriteLine($"> {prompt2}");
            Activity.spinerAni(10);
        }
        
        base.endMesseg();
    }
        
}

public class ListingActivity : Activity {

    private List<string> questions = new List<string>() {"when have you felt the Holy Ghost this month","what spiritual exspeirence did you have when you visited the temple last ","what have you learned from the scriptures this week"};
    private List<string> responses = new List<string>();
    private void getInfo() {
        
        _activityName = "listing activity";
        _activityInfo = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void display() {
        getInfo();
        base.display(_activityName);
    }

    public void runActivity() {

        base.runActivity();

        Random randomSelect = new Random();
        int randNum = randomSelect.Next(questions.Count);
        string prompt = questions[randNum];

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in: ");
        Activity.countDownAni(5);


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_sessionTime);

        while (DateTime.Now <= endTime){

            Console.Write("> ");
            string respose = Console.ReadLine();
            responses.Add(respose);

        }

        Console.WriteLine($"You listed {responses.Count()} items!");
        responses.Clear();
        base.endMesseg();
    
    }
}
