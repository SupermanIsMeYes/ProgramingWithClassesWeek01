class Reflection : Activity
{
  
  private int lengthOfActivity = 0;

  Random rand = new Random();

  private List<string> myListFirst = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
  private List<string> myListSecond = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?" };
    public void StartProgram()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.Write("This activity will help you reflect on the times in your life when you have shown strength and resilience.");
        Console.WriteLine(" This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to be? ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out lengthOfActivity))
        {
            Activity activity = new Activity();
            Thread counterThread = new Thread(() => activity.StartCounter(3));
            Thread animationThread = new Thread(() => activity.StartAnimation("Get ready..."));
            counterThread.Start();
            animationThread.Start();
            counterThread.Join();
            activity.StopAnimation();
            animationThread.Join();

            double numberOfTimes = Math.Ceiling((double)lengthOfActivity / 30);
            //double numberOfTimes1 = Math.Ceiling((double)lengthOfActivity / 30);

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.Clear();
                int number = rand.Next(0, myListFirst.Count);
                Console.WriteLine("Consider the following prompt:\n");
                Console.WriteLine($"--- {myListFirst[number]} ---\n");
                Console.WriteLine("When you have something in mind, press enter to continue...");
                string input = Console.ReadLine();
                
                if (input == "")
                {
                    Console.Clear();
                    for (int a = 5; a >= 1; a--)
                    {
                        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                        Console.Write("You may begin in: ");
                        Console.Write(a);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    Console.Clear();
                    Activity activity2 = new Activity();
                    number = rand.Next(0, myListSecond.Count);
                    Thread counterThread2 = new Thread(() => activity2.StartCounter(10));
                    Thread animationThread2 = new Thread(() => activity2.StartAnimation(myListSecond[number]));
                    counterThread2.Start();
                    animationThread2.Start();
                    counterThread2.Join();
                    activity2.StopAnimation();
                    animationThread2.Join();

                    Console.Clear();
                    Activity activity3 = new Activity();
                    int number1 = rand.Next(0, myListSecond.Count);
                    Thread counterThread3 = new Thread(() => activity3.StartCounter(10));
                    Thread animationThread3 = new Thread(() => activity3.StartAnimation(myListSecond[number] + "\n" + myListSecond[number1]));
                    counterThread3.Start();
                    animationThread3.Start();
                    counterThread3.Join();
                    activity3.StopAnimation();
                    animationThread3.Join();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Console.Clear();

            Activity activity1 = new Activity();
            Thread counterThread1 = new Thread(() => activity1.StartCounter(3));
            Thread animationThread1 = new Thread(() => activity1.StartAnimation($"Well done!!\n\nYou have completed another {lengthOfActivity} seconds of Reflecting Activity\n"));
            counterThread1.Start();
            animationThread1.Start();
            counterThread1.Join();
            activity1.StopAnimation();
            animationThread1.Join();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 0 seconds.");
        }

    }

}