

class Goal
{

    public int points = 0;
    public string type = "1";
    public string name = "new goal";
    public string discription = "my discription";
    public string alocatedPoints = "0";

    public List<List<string>> goals = new List<List<string>>();
    
    public virtual void createGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        type = Console.ReadLine();
        Console.WriteLine("What is the name of the goal?");
        name = Console.ReadLine();
        Console.WriteLine("What is a short discription of the goal?");
        discription = Console.ReadLine();
        Console.WriteLine("What is the amount of associated points for the goal?");
        alocatedPoints = Console.ReadLine();
    }

    public virtual void recordGoal(string type,string name, string discription,string alocatedPoints)
    {
        goals.Add(new List<string> { type, name, discription, alocatedPoints, "Unchecked" });
    }




}