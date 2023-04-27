using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueIt = true;
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int magicNumber = Convert.ToInt32(input);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        while (continueIt)
        {
            bool numberCorrect = false;
            Console.Write("What is your guess? ");
            string input2 = Console.ReadLine();
            int guess = Convert.ToInt32(input2);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
                numberCorrect = true;
            }
            
            if (numberCorrect)
            {
                continueIt = false;
            }
            

}
    }
}