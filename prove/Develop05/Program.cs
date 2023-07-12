using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
            bool continueit = true;
            Goal myGoalLists = new Goal();
            Console.WriteLine();
            Console.WriteLine("Points: 0");
            Console.WriteLine();
            while (continueit)
            {
            
            string input = "0"; 
            Console.WriteLine("Menu Opitons:");
            Console.WriteLine(" 1. Create new goal");
            Console.WriteLine(" 2. List goal");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load goals");
            Console.WriteLine(" 5. Record an envent");
            Console.WriteLine(" 6. Quit");
            Console.Write("Type a number to select a item from the menu. ");
            input = Console.ReadLine();
            Console.WriteLine();
            string fileName = "Goals.txt";
            string number = "0";


            switch (int.Parse(input))
            {
                case 1:
                    myGoalLists.createGoal();
                    myGoalLists.recordGoal(myGoalLists.type, myGoalLists.name, myGoalLists.discription,myGoalLists.unChecked,myGoalLists.numberCompleted,myGoalLists.numberToComplete, myGoalLists.alocatedPoints, myGoalLists.bonus, myGoalLists.points);
                    break;
                case 2:
                    int counter = 0;
                    Console.WriteLine("Your Goals: ");
                    foreach (List<string> goal in myGoalLists.goals)
                    {
                        counter += 1;
                        if (goal[0] != "3")
                        {
                            Console.WriteLine($"{counter}. [{goal[3]}] {goal[1]} ({goal[2]})");
                        }
                        if (goal[0] == "3")
                        {
                            Console.WriteLine($"{counter}. [{goal[3]}] {goal[1]} ({goal[2]}) -- Currently Completed {goal[4]}/{goal[5]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Points: {myGoalLists.goals[0][8]}");
                    Console.WriteLine();

                    break;
                case 3:
                    Console.Write("What is the file name of the text file where you would like to store your goals? ");
                    fileName = Console.ReadLine();
                    Console.WriteLine();
                    FileManager.WriteList(myGoalLists.goals, fileName);
                    break;
                case 4:
                    Console.Write("What is the file name of the text file that has your goals? ");
                    fileName = Console.ReadLine();
                    Console.WriteLine();
                    myGoalLists.goals = FileManager.ReadList(fileName);
                    break;
                case 5:
                    int counter2 = 0;
                    Console.WriteLine("Your Goals: ");
                    foreach (List<string> goal in myGoalLists.goals)
                    {
                        counter2 += 1;
                        if (goal[0] != "3")
                        {
                            Console.WriteLine($"{counter2}. [{goal[3]}] {goal[1]} ({goal[2]})");
                        }
                        if (goal[0] == "3")
                        {
                            Console.WriteLine($"{counter2}. [{goal[3]}] {goal[1]} ({goal[2]}) -- Currently Completed {goal[4]}/{goal[5]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Points: {myGoalLists.goals[0][8]}");
                    Console.WriteLine();
                    Console.Write("Which goal did you acomplish? ");
                    number = Console.ReadLine();
                    Console.WriteLine();
                    if (myGoalLists.goals[int.Parse(number) - 1][0] == "1")
                    {
                        Simple temp = new Simple();
                        temp.recordEvent(myGoalLists.goals,number);
                    }
                    if (myGoalLists.goals[int.Parse(number) - 1][0] == "2")
                    {
                        Eternal.recordEventEternal(myGoalLists.goals,number);
                    }
                    if (myGoalLists.goals[int.Parse(number) - 1][0] == "3")
                    {
                        Checklist.recordEventChecklist(myGoalLists.goals,number);
                    }
                    break;
                case 6:
                    continueit = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            if (int.Parse(input) != 2)
                {
                    int counter3 = 0;
                    Console.WriteLine("Your Goals: ");
                    foreach (List<string> goal in myGoalLists.goals)
                    {
                        counter3 += 1;
                        if (goal[0] != "3")
                        {
                            Console.WriteLine($"{counter3}. [{goal[3]}] {goal[1]} ({goal[2]})");
                        }
                        if (goal[0] == "3")
                        {
                            Console.WriteLine($"{counter3}. [{goal[3]}] {goal[1]} ({goal[2]}) -- Currently Completed {goal[4]}/{goal[5]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Points: {myGoalLists.goals[0][8]}");
                    Console.WriteLine();
                }
            }
    }
}