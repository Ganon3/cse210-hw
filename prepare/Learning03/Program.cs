using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(1,3);

        // fraction1.GetFractionString();
        // fraction2.GetFractionString();
        // fraction3.GetFractionString();

        //fraction1.getTop(21);
        //fraction1.getBot(100);
        //fraction1.GetFractionString();

        double div3 = fraction3.GetDecimalValue();
        double div1 = fraction1.GetDecimalValue();
        double div2 = fraction2.GetDecimalValue();

        Console.WriteLine(div1);
        Console.WriteLine(div2);
        Console.WriteLine(div3);
    }
}