using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.SetBottom(7);
        int fBottom = f.GetBottom();

        Fraction f1 = new Fraction(6);

        Fraction f2 = new Fraction(5, 3);

        Console.WriteLine($"{f.GetFractionString()} -> {f1.GetTop()} -> {f2.GetDecimalValue()}");

    }
}