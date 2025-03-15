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

    // I realized I may not need this and I may en up deleting it later
    //public abstract void UpdateEvents();

    public abstract bool IsGoalComplete();

    public abstract int UpdateGoal(int points);
}