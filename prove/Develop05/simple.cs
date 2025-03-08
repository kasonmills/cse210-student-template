using System;

namespace goals;

class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points) :base(name, description, points)
    {

    }
    protected override void UpdateEvents()
    {

    }

    protected override bool IsGoalcomplete()
    {
        return false;
    }
}