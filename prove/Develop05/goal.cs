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

    public string GetNameOfGoal()
    {
        return "";
    }

    public string GetGoalDetails()
    {
        return "";
    }

    protected int GetPoints()
    {
        return 0;
    }
}