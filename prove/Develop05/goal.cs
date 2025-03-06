using System;

namespace goals;

abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected abstract void UpdateEvents();

    protected abstract bool IsGoalcomplete();

    protected abstract string GetNameOfGoal();

    protected abstract string GetGoalDetails();
}