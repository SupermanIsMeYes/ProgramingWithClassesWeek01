using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        bool continueIt = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (continueIt)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number != 0) 
            { 
                numbers.Add(number);
            }

            if (number == 0)
            {
                continueIt = false;
                Console.WriteLine();
            }
        }
        
        double average = numbers.Count > 0 ? numbers.Average() : 0.0;
        Console.WriteLine($"The sum is: {numbers.Sum(x => Convert.ToInt32(x))}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}