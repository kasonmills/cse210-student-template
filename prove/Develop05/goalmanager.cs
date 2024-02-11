using System;
using System.Diagnostics;

namespace goals;

class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoals()
    {

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
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal}");
            count++;
        }
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
            string[] stuff = line.Split(",");

            _score = int.Parse(stuff[0]);

            _goals.Add(new Goal());
        }
    }
}