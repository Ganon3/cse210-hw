using System;

class Program
{
    static void Main(string[] args)
    {
        int five = 5;
        int twelve = 12;
        int six = 6;

        // lets say we wanted to take in two numbers and output the sum
        // we could just add them here

        int sum = five + twelve + six;
        Console.Write(sum);

        // but what if you had to deal with over onethousand number .. your not going to write each one down
        // so you make a funtion to take in all those numbers and add them all

       

        static void addNumbers(List<int> numbers) {

            int sum = 0;
            foreach (int number in numbers)
            { 
                sum = sum + number;
            }
            Console.WriteLine(sum);
        } 

        // now insted of writing out thousands of number, we can get a funtion to add all the number for us

        List<int> numbers = new List<int> {1,2,33,4,55,6,77,8,9,10,123,345,654,34567,6,567,8,76,545,67,9,6543,4,4,3,4,};
        addNumbers(numbers);
        
       





    }
}