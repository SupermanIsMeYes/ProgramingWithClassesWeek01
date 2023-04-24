using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string pass = "pass";
        string letter = "F";
        
        if (grade >= 90)
        {
            //Console.WriteLine("Your grade is an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("Your grade is an B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("Your grade is an C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("Your grade is an D");
            letter = "D";
            pass = "fail";
        }
        else
        {
            Console.WriteLine("Your grade is an F");
            pass = "fail";
        }

        Console.WriteLine($"Your grade is an {letter}");
        
        if (pass == "pass")
        {
            Console.WriteLine("Congrats you pass!!");
        }
        else 
        {
            Console.WriteLine("Better luck next time you fail.");
        }
    }
}