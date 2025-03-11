using System;

namespace goals;

abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void UpdateEvents();

    public abstract bool IsGoalcomplete();

    public abstract string GetNameOfGoal();

    public abstract string GetGoalDetails();

    public abstract int GetPoints();
}