using System;
using System.Runtime;

namespace goals;

class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int target, int bonus, int amountCompleted) :base(name, description, points)
    {
        _target = target;
        _bonusPoints = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsGoalComplete()
    {
        Console.WriteLine("Did you complete your goal? (please input y or n)\n");
        string response = Console.ReadLine();
        if (response == "y")
        {
            return true;
        }
        else{
            return false;
        }
    }

    public override int UpdateGoal(int points)
    {
        bool place = IsGoalComplete();

        if (place)
        {
            if(_target > _amountCompleted)
            {
            _amountCompleted++;
            return points;
            }
            else
            {
                return _bonusPoints;
            }
        }
        else
        {
            return 0;
        }
        
    }
}