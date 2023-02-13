using System;

class Program
{
    static void Main(string[] args)
    {

        StringToList stl = new StringToList();
        BlankOutList bol = new BlankOutList();
        Display dis = new Display();

        bol.getList(stl.ConvertToList());
        dis.getList(bol.GiveList());
            
        bool app_on = true;
        do {
            
            dis.display();
            Console.WriteLine("");
            Console.WriteLine("Press enter to cuntinue or type 'quit' to stop");
            string answer = Console.ReadLine();

            bol.blankIt();
            dis.getList(bol.GiveList());
            
            
            if (answer == "quit" || bol.checkLits(dis.displayList) == false) {
                Console.Clear(); 
                dis.display();
                Console.WriteLine("");
                app_on = false;
                }

            else {Console.Clear();}

        } while (app_on == true);
    }
}