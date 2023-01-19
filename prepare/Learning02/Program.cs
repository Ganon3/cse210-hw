using System;

class Program
{
    private static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        // Console.WriteLine(job1._jobTitle);
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        // job2.Display();

        Resume rresume = new Resume();

        rresume.jobs.Add(job1);
        rresume.jobs.Add(job2);
        // rresume.jobs[0].Display();
        // rresume.jobs[1].Display();
        rresume._name = "Fuad J Torres";
        rresume.Dispaly();
    }
}