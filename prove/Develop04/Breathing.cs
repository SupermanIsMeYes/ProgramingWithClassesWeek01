using System;

class Breathing : Activity
{
    private int lengthOfActivity = 0;

    public void StartProgram()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to be? ");
        string userInput = Console.ReadLine();

        // Validate and convert user input
        if (int.TryParse(userInput, out lengthOfActivity))
        {
            Activity activity = new Activity();
            Thread counterThread = new Thread(() => activity.StartCounter(3));
            Thread animationThread = new Thread(() => activity.StartAnimation("Get ready..."));
            counterThread.Start();
            animationThread.Start();

            // Wait for the counter thread to complete
            counterThread.Join();

            // Signal the animation thread to stop
            activity.StopAnimation();

            // Wait for the animation thread to complete
            animationThread.Join();

            double numberOfTimes = Math.Ceiling((double)lengthOfActivity / 10);

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.Clear();
                for (int a = 1; a <= 3; a++)
                {
                    Console.Write("Breathe in...");
                    Console.Write(a);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Write("Breathe in...");
                Thread.Sleep(2000);
                Console.Clear();
                for (int b = 1; b <= 3; b++)
                {
                    Console.Write("Breathe in...");
                    Console.Write("\nNow Breathe out...");
                    Console.Write(b);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Write("Breathe in...");
                Console.Write("\nNow Breathe out...");
                Thread.Sleep(2000);

            }
            Console.Clear();

            Activity activity1 = new Activity();
            Thread counterThread1 = new Thread(() => activity1.StartCounter(3));
            Thread animationThread1 = new Thread(() => activity1.StartAnimation($"Well done!!\n\nYou have completed another {lengthOfActivity} seconds of Breathing Activity\n"));
            
            counterThread1.Start();
            animationThread1.Start();

            counterThread1.Join();

            activity1.StopAnimation();

            animationThread1.Join();
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 0 seconds.");
        }
    }
}