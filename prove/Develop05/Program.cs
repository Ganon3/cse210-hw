using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sGoal = new SimpleGoal();
        EternalGoal eGoal = new EternalGoal();
        CheckListGoal cGoal = new CheckListGoal();

        Mainn mainn = new Mainn();
        fileWorker worker = new fileWorker();

        bool app_on = true;
        while (app_on)
        {
            string choice = mainn.displayOptions();

            if (choice == "1") // creat new goal
            {
                string goal = mainn.GoalCreationOptions();

                if (goal == "1") // simple goal
                {
                    Console.Write("what is the name of your Goal? ");
                    sGoal.setName(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("how will you acomplish that goal? ");
                    sGoal.setinfo(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("how much points are asscociated with this gaol? ");
                    sGoal.setReword(Console.ReadLine());
                    Console.WriteLine("");
                    sGoal.setGoalType();
                    sGoal.setDisplay();
                    mainn.addToMainnlist(sGoal.GiveStringToMainn());
                }

                else if (goal == "2") // eternal goal
                {
                    Console.Write("what is the name of your Goal? ");
                    eGoal.setName(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("how will you acomplish that goal? ");
                    eGoal.setinfo(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("how much points are asscociated with this gaol? ");
                    eGoal.setReword(Console.ReadLine());
                    Console.WriteLine("");
                    eGoal.setGoalType();
                    eGoal.setDisplay();
                    mainn.addToMainnlist(eGoal.GiveStringToMainn());
                }

                else if (goal == "3") // checklist goal
                {
                    Console.Write("what is the name of your Goal? ");
                    cGoal.setName(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("how will you acomplish that goal? ");
                    cGoal.setinfo(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("how much points are asscociated with this gaol? ");
                    cGoal.setReword(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("how many times does this goal need to be acomplished");
                    cGoal.setHowManyTimes(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("how much bonus points are associated with acomplishment?");
                    cGoal.setBonus(Console.ReadLine());
                    Console.WriteLine("");
                    cGoal.setGoalType();
                    cGoal.setDisplay();
                    mainn.addToMainnlist(cGoal.GiveStringToMainn());
                }

                else {Console.WriteLine("That is not an option"); Console.WriteLine("");}

            }

            else if (choice == "2") // list Goals
            {mainn.DisplayGoals();}

            else if (choice == "3") // save Goals
            {
                Console.WriteLine("what is the name of the file (.txt file)");
                worker.setFileName(Console.ReadLine());
                worker.setfromMainn(mainn.giveListToFileWorker());
                worker.saveFileInfo();
            }

            else if (choice == "4") // load goal
            {
                Console.WriteLine("what is the name of the file (.txt file)");
                worker.setFileName(Console.ReadLine());
                worker.setFromFile();
                mainn.setMainnlist(worker.shairFileInfo());
            }

            else if (choice == "5") // record an event
            {
                int rchoice = mainn.recordChoice();
                if (rchoice > mainn.getlistcount()-1) {Console.WriteLine("That item does not exsist");}
                else if (rchoice <= mainn.getlistcount()-1) 
                {
                    List<string> onHold = mainn.giveWordsToGoals(rchoice);

                    if (onHold[0] == "SG") 
                    {
                        sGoal.reSetList(onHold);
                        sGoal.recodEvent();
                        mainn.addToMainnlist(sGoal.GiveStringToMainn());
                    }
                    else if (onHold[0] == "EG") 
                    {
                        eGoal.reSetList(onHold);
                        eGoal.recodEvent();
                        mainn.addToMainnlist(eGoal.GiveStringToMainn());
                    }
                    else if (onHold[0] == "CG") 
                    {
                        cGoal.reSetList(onHold);
                        cGoal.recodEvent();
                        mainn.addToMainnlist(cGoal.GiveStringToMainn());
                    }

                    onHold.Clear();

                }
            }

            else if (choice == "6") // quit
            {app_on = false;}

            else {Console.WriteLine("That is not an option"); Console.WriteLine("");}
        }
    }
}