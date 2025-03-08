using System;

namespace goals;

class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
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