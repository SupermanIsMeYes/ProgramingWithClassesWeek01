using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //int waitTimeInSeconds = 5; // Specify the amount of time to wait in seconds

        // Start the counter and animation concurrently
        //Activity activity = new Activity();

        //Thread counterThread = new Thread(() => activity.StartCounter(waitTimeInSeconds));
        //Thread animationThread = new Thread(() => activity.StartAnimation());
        //counterThread.Start();
        //animationThread.Start();

        // Wait for the counter thread to complete
        //counterThread.Join();

        // Signal the animation thread to stop
        //activity.StopAnimation();

        // Wait for the animation thread to complete
        //animationThread.Join();

        // Counter and animation completed
        //Console.WriteLine("Process completed.");

        //Breathing breathing1 = new Breathing();
        //breathing1.StartProgram();
        //Reflection reflection1 = new Reflection();
        //reflection1.StartProgram();
        //Listing listing1 = new Listing();
        //listing1.StartProgram();

        bool exitMenu = false;

        while (!exitMenu)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("0. Exit");

  
            Console.Write("Enter your choice(1-3): ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Breathing breathing1 = new Breathing();
                    breathing1.StartProgram();

                    break;
                case "2":
                    Reflection reflection1 = new Reflection();
                    reflection1.StartProgram();
   
                    break;
                case "3":
                    Listing listing1 = new Listing();
                    listing1.StartProgram();
         
                    break;
                case "0":
                    exitMenu = true;
                    Console.WriteLine("Exiting the Program. Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}

