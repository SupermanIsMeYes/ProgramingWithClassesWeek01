

class Goal
{

    public string points = "0";
    public string type = "1";
    public string name = "new goal";
    public string discription = "my discription";
    public string alocatedPoints = "0";

    public string numberCompleted = "0";

    public string numberToComplete = "0";
    public string unChecked = " ";

    public string bonus = "";

    public List<List<string>> goals = new List<List<string>>();
    
    public virtual void createGoal()
    {
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checked goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        type = Console.ReadLine();
        Console.Write("\nWhat is the name of the goal? ");
        name = Console.ReadLine();
        Console.Write("\nWhat is a short discription of the goal? ");
        discription = Console.ReadLine();
        Console.Write("\nWhat is the amount of associated points for the goal? ");
        alocatedPoints = Console.ReadLine();

        if (type == "3")
        {
            Console.Write("\nHow many times does this goal need to be acomplished for a bonus? ");
            numberToComplete = Console.ReadLine();
            Console.Write("\nWhat is the bonus for acomplishing it that many times? ");
            bonus = Console.ReadLine();
        }


    }

    public virtual void recordGoal(string type, string name, string discription, string unChecked, string numberCompleted, string numberToComplete, string alocatedPoints, string bonus,string points)
    {
        goals.Add(new List<string> { type, name, discription, unChecked, numberCompleted, numberToComplete, alocatedPoints, bonus, points});
    }

    public virtual List<List<string>> recordEvent(List<List<string>> goals, string number)
    {
        List<List<string>> newList = new List<List<string>>(goals);
        return newList;
    }
}