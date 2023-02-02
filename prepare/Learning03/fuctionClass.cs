using System;

public class Fraction 
{
    private int _top;
    private int _bot; 

    public Fraction() {_top = 1; _bot = 1;}
    public Fraction(int top) {_top = top; _bot = 1;}
    public Fraction(int top, int bot) {_top = top; _bot = bot;}
    
    public void getTop(int top) {_top = top;}
    public void getBot(int bot) {_bot = bot;}
    public void GetFractionString () {Console.WriteLine($"Fraction: {_top}/{_bot}");}
    public double GetDecimalValue() {return (double)_top/(double)_bot;}
    
    


}