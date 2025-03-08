using System;

namespace goals;

class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public Checklist(string name, string description, int points) :base(name, description, points)
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