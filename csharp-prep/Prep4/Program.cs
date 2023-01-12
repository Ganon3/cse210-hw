using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("Enter number: ");
            string newNum = Console.ReadLine();
            if (num != 0) {num = int.Parse(newNum); numbers.Add(num);}
            else {num = int.Parse(newNum);}
        }
        
        int sum = 0;
        int largest = int.MinValue;
        int smallest = int.MaxValue;
        foreach (int number in numbers) 
        {
            sum = sum + number;
            if (number > largest) {largest = number;}
            if (number < smallest && number > 0) {smallest = number;}
        } 
        int devide = numbers.Count-1; float average = (float)sum / devide;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers) {Console.WriteLine(number);}
    }
}