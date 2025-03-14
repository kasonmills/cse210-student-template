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
        return true;
    }

    public override void UpdateGoal()
    {

    }
}