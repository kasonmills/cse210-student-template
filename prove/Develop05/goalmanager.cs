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
            DisplayPlayerScore();
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
                        RecordEvent(points);
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

    public void DisplayPlayerScore()
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
                count++;
            }
        }
    }

    public string GetNameOfGoal()
    {
        Console.WriteLine("What is the will be the name of your new goal?\n");
        string name = Console.ReadLine();
        return name;
    }

    public string GetGoalDetails()
    {
        Console.WriteLine("how would you describe this goal?\n");
        string details = Console.ReadLine();
        return details;
    }

    public int GetPoints(bool ifBonus)
    {
        string place;
        if(ifBonus)
        {
            Console.WriteLine("how many bonus points will you get once you reach the target?\n");
            place = Console.ReadLine();
            int points = int.Parse(place);
            return points;
        }
        else{
            Console.WriteLine("how many points will you get when you accomplish your goal?\n");
            place = Console.ReadLine();
            int points = int.Parse(place);
            return points;
        }
    }

    public int GetTargetToGetBonus()
    {
        Console.WriteLine("How many times to do need to complete your goal to get the bonus?\n");
        string hold = Console.ReadLine();
        int target = int.Parse(hold);
        return target;
    }
    public void NewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create?\n");
        string input = Console.ReadLine();
        int goalType = int.Parse(input);

        switch (goalType)
        {

            case 1:
                {
                    _goals.Add(new Simple(GetNameOfGoal(), GetGoalDetails(), GetPoints(false)));
                    break;
                }
            case 2:
                {
                    _goals.Add(new Eternal(GetNameOfGoal(), GetGoalDetails(), GetPoints(false)));
                    break;
                }
            case 3:
                {
                    _goals.Add(new Checklist(GetNameOfGoal(), GetGoalDetails(), GetPoints(false), GetTargetToGetBonus(), GetPoints(true), 0));
                    break;
                }
            default:
                {
                    Console.WriteLine("There are only three goal types please try again.");
                    break;
                }
        }
    }

    public void RecordEvent(int points)
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals available.");
            return;
        }

        ListGoals();
        Console.Write("Enter goal number to update: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        // I need to be able to specify goals by type so I will know how to update them.
        switch (_goals[index])
        {
            case Simple:
            {
                _goals[index].UpdateGoal(points);
                _score += points;
                break;
            }
            case Eternal:
            {
                _goals[index].UpdateGoal(points);
                _score += points;
                break;
            }
            case Checklist:
            {
                _goals[index].UpdateGoal(points);
                _score += points;
                break;
            }
        }
        
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file did you want to save your goals to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            outputFile.WriteLine(_goals);
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file did you want to load your goals from? ");
        string fileName = Console.ReadLine();

        _goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            if (line.StartsWith("SCORE"))
            {
                _score = int.Parse(line.Split(',')[1]);
            }

            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split(',');
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                switch (type)
                {
                    case "Simple":
                        bool isComplete = bool.Parse(parts[4]);
                        _goals.Add(new Simple(name, desc, points));
                        break;
                    case "Eternal":
                        _goals.Add(new Eternal(name, desc, points));
                        break;
                    case "Checklist":
                        int completed = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        _goals.Add(new Checklist(name, desc, points, target, bonus, completed));
                        break;
                }
            }
        }
    }
}
