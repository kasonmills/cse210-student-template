using System;

namespace goals;

abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    public bool _isComplete;
    
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    // I realized I may not need this and I may en up deleting it later
    //public abstract void UpdateEvents();

    public abstract bool IsGoalComplete();

    public abstract int UpdateGoal(int _points);
}