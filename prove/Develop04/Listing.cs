class Listing : Activity
{
  private int lengthOfActivity = 0;
  private bool timerExpired = false;

  Random rand = new Random();

  private List<string> myListOfPrompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
  private List<string> myListOfResponses = new List<string> {};
    public void StartProgram()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");  
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to be? " );
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

                Console.Clear();
                int number = rand.Next(0, myListOfPrompts.Count);
            for (int a = 5; a >= 1; a--)
                    {
                        Console.WriteLine("List as many reponses as you can to following prompt:\n");
                        Console.WriteLine($"--- {myListOfPrompts[number]} ---\n");
                        Console.Write("You may begin in: ");
                        Console.Write(a);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

            Thread timerThread = new Thread(() => StartTimer(lengthOfActivity));;
            timerThread.Start();
        
        while (!timerExpired)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response.ToLower() == "exit")
            {
                // Stop the timer and exit the loop
                timerExpired = true;
                break;
            }
            myListOfResponses.Add(response);
        }

            Activity activity1 = new Activity();
            Thread counterThread1 = new Thread(() => activity1.StartCounter(3));
            Thread animationThread1 = new Thread(() => activity1.StartAnimation($"You listed {myListOfResponses.Count}\n\nWell done!!\n\nYou have completed another {lengthOfActivity} seconds of Listing Activity\n"));
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
    private void StartTimer(int lengthOfActivity)
    {
        Thread.Sleep(lengthOfActivity * 1000);
        timerExpired = true;
    }
}
