using System.Globalization;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    Fraction n = new Fraction();
    Console.WriteLine(n.GetFractionString());
    Console.WriteLine(n.GetDecimalValue());

    Fraction n1 = new Fraction(5);
    Console.WriteLine(n1.GetFractionString());
    Console.WriteLine(n1.GetDecimalValue());

    Fraction n2 = new Fraction(3,4);
    Console.WriteLine(n2.GetFractionString());
    Console.WriteLine(n2.GetDecimalValue());

    Fraction n3 = new Fraction(1,3);
    Console.WriteLine(n3.GetFractionString());
    Console.WriteLine(n3.GetDecimalValue());
    }
}