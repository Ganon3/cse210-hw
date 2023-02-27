using System;

class Program
{
    static void Main(string[] args) {

        static void spinerAni(int seconds) {

            List<string> _spinerAni = new List<string>() {"-","\\","|","/","-"};

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            while (DateTime.Now < endTime) {

                foreach (string s in _spinerAni) {

                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
               }
           }
       }

       spinerAni(1);
    }
}