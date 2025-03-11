using System;

namespace goals;

class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int target, int bonus) :base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonusPoints = bonus;
    }
    public override void UpdateEvents()
    {

    }

    public override bool IsGoalcomplete()
    {
        return false;
    }

    public override string GetGoalDetails()
    {
        return "";
    }

    public override string GetNameOfGoal()
    {
        return "";
    }

    public override int GetPoints()
    {
        return 0;
    }
}