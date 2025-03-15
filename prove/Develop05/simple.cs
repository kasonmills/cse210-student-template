using System;

namespace goals;

class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points) :base(name, description, points)
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

    public override void UpdateGoal()
    {

    }
}