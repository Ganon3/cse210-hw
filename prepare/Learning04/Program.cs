using System;

class Program
{
    static void Main(string[] args)
    {
       MathAssignment math = new MathAssignment("fuad","c#","week7","super and sub classes");
       WirtingAssignment writing = new WirtingAssignment("fuad","c#","Describe the valuse and usses of student classes");

       Console.WriteLine(math.GetHomeworkList());
       Console.WriteLine(writing.GetWritingInfomation());
    }
}