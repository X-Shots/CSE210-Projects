using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction(3,4);
        Console.WriteLine(a.getFractionDecimal());
        Console.WriteLine(a.getFractionString());
    }
}