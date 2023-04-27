using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            return number;
        }
        static int SquareNumber(int number)
        {
            int sqaure = number * number;
            return sqaure;
        }
        void DisplayResult()
        {
            string name = PromptUserName();
            int number = PromptUserNumber();
            number = SquareNumber(number);

            Console.Write($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        DisplayResult();

    }
}