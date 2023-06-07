using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments new1 = new Assignments("Samuel Bennett", "Multiplication");
        Console.WriteLine(new1.GetSummary());

        math new2 = new math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(new2.GetSummary());
        Console.WriteLine(new2.GetHomework());

        Writing new3 = new Writing ("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(new3.GetSummary());
        Console.WriteLine(new3.GetWriting());
    }
}