using System;

namespace goals;

class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int target, int bonus) :base(name, description, points)
    {
        _target = target;
        _bonusPoints = bonus;
    }

    public override bool IsGoalComplete()
    {
        return false;
    }

    public override void UpdateGoal()
    {

    }
}