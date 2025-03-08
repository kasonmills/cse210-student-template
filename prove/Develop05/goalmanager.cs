using System;
using System.Diagnostics;

namespace goals;

class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public void Start()
    {

    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Events");
        Console.WriteLine("\t6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        // I think this method will be for the exceeds expectations part...
    }

    public void ListGoals()
    {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"\t{count}. {goal}");
            count++;
        }
    }

    public void ListDetails()
    {

    }

    public void NewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        int goalType = int.Parse(input);

        switch(goalType)
        {
            case 1:
            {
                Simple goal = new Simple(GetNameOfGoal(), GetGoalDetails(), 0);
                break;
            }
            case 2:
            {
                Eternal goal = new Eternal(GetNameOfGoal(), GetGoalDetails(), 0);
                break;
            }
            case 3:
            {
                Checklist goal = new Checklist(GetNameOfGoal(), GetGoalDetails(), 0);
                break;
            }
        }
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
       
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file did you save your goals to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            outputFile.WriteLine(_goals);
        }      
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file did you save your goals to? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            // so this loop needs to be able to read the type of goal then create a new instance of that goal and then
            // add that to the List<Goal> objects right?
            int i = 0;
            string[] stuff = line.Split(",");

            _score = int.Parse(stuff[0]);

            stuff[i].Split(":");

            //_goals.Add();
        }
    }
}