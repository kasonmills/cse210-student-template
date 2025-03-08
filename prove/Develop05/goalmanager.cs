using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace goals;

class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int selection;
        do
        {
            DisplayMenu();
            string input = Console.ReadLine();
            selection = int.Parse(input);
            switch (selection)
            {
                case 1:
                    {
                        NewGoal();
                        break;
                    }
                case 2:
                    {
                        ListGoals();
                        break;
                    }
                case 3:
                    {
                        SaveGoals();
                        break;
                    }
                case 4:
                    {
                        LoadGoals();
                        break;
                    }
                case 5:
                    {
                        RecordEvent();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        } while (selection != 6);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create new Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Events");
        Console.WriteLine("\t6. Quit");
        Console.WriteLine("Please select a choice from the menu.");
    }

    public void DisplayPlayerInfo()
    {
        // this method might be a part of the exceeds expectations portion of the program
        // so I will come back to it later
        Console.WriteLine($"\nPlayer Score: {_score}");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals set.");
            return;
        }
        else
        {
            int count = 1;
            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{count}. {goal}");
                Console.WriteLine(goal.GetGoalDetails());
                count++;
            }
        }
    }

    public void ListDetails()
    {
        // this method might be redundant if I don't decided to have the goal listed as a part of the other
        // method
    }

    public void NewGoal(Goal _goals)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        int goalType = int.Parse(input);

        switch (goalType)
        {

            case 1:
                {
                    Simple goal = new Simple("", "", 0);
                    // _goals.add(goal);
                    break;
                }
            case 2:
                {
                    Eternal goal = new Eternal("", "", 0);
                    break;
                }
            case 3:
                {
                    Checklist goal = new Checklist("", "", 0);
                    break;
                }
            default:
                {
                    Console.WriteLine("There are only three goal types please try again.");
                    break;
                }
        }
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

        foreach (string line in lines)
        {
            string[] stuff = line.Split(",");

            _score = int.Parse(stuff[0]);

            _goals.Add(new Goal());
        }
    }
}