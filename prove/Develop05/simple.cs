using System;

namespace goals;

class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points) :base(name, description, points)
    {

    }

    public override bool IsGoalcomplete()
    {
        return true;
    }
}