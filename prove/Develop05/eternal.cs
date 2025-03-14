using System;

namespace goals;

class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool IsGoalComplete()
    {
        return false;
    }

    public override void UpdateGoal()
    {

    }
}