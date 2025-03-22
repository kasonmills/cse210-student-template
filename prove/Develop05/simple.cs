using System;

namespace goals;

class Simple : Goal
{

    public Simple(string name, string description, int points, bool isComplete) :base(name, description, points, isComplete)
    {

    }

    public override bool IsGoalComplete()
    {
        Console.WriteLine("Did you complete your goal? (please input y or n)\n");
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
        if(isComplete)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
}