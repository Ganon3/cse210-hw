using System;

class Program
{
    static void Main(string[] args)
    {
       Mainn mainn = new Mainn();
       BreathingActivity breath = new BreathingActivity();
       ReflectionActivity reflect = new ReflectionActivity();
       ListingActivity listing = new ListingActivity();

       bool app_on = true;
       while (app_on) {

        string answer = mainn.options();

        if (answer == "1") // breathing activity
        {
            breath.display();
            breath.RunActivity();
        }
        else if (answer == "2") // reflecting activity 
        {
            reflect.display();
            reflect.runActivity();
        }
        else if (answer == "3") // listing activity
        {
            listing.display();
            listing.runActivity();
        }
        else if (answer == "4") // quit
        {
            app_on = false;
        }
        else {
            
            Console.WriteLine("Pleas pick a number 1-4");
            mainn.spinerAni(4);
            Console.Clear();
        }
       }
    }
}