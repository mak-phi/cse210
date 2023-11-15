using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        f1.SetNumerator(3);
        // Console.WriteLine(f1.GetNumerator());
        f1.SetDenominator(14);
        // Console.WriteLine(f1.GetDenominator());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction pi = new Fraction(22, 7);
        Console.WriteLine(pi.GetFractionString());
        Console.WriteLine(pi.GetDecimalValue());
        //Console.WriteLine(Math.PI);
    }
}