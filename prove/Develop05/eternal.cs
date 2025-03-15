using System;

namespace goals;

class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool IsGoalComplete()
    {
        Console.WriteLine("Did you make progress on your goal? (please input y or n)\n");
        string response = Console.ReadLine();
        if (response == "y")
        {
            return true;
        }
        else{
            return false;
        }
    }

    public override int UpdateGoal(int points)
    {
        bool complete = IsGoalComplete();
        if (complete)
        {
            complete = false;
            return points;
        }
        else
        {
            return 0;
        }

    }
}