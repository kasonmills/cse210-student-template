using System;

namespace goals;

class Eternal : Goal
{
    public Eternal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
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

    public override int UpdateGoal(int _points)
    {
        bool isComplete = IsGoalComplete();
        if (isComplete)
        {
            isComplete = false;
            return _points;
        }
        else
        {
            return 0;
        }

    }
}