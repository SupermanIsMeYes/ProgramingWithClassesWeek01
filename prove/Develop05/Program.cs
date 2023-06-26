using System;

class Program
{
    static void Main(string[] args)
    {
        
        Goal myGoalLists = new Goal();
        myGoalLists.createGoal();
        myGoalLists.recordGoal(myGoalLists.type, myGoalLists.name, myGoalLists.discription, myGoalLists.alocatedPoints);
        int counter = 0;
        foreach (List<string> goal in myGoalLists.goals)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {goal[1]} ({goal[2]})");
        }
    }
}