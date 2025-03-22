using System;
using System.Runtime;

namespace goals;

class Checklist : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonusPoints;

    public Checklist(string name, string description, int points, bool isComplete, int target, int bonus, int amountCompleted) :base(name, description, points, isComplete)
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

    public override int UpdateGoal(int _points)
    {
        bool isComplete = IsGoalComplete();

        if (isComplete)
        {
            if(_target >= _amountCompleted)
            {
                isComplete = false;
                _amountCompleted++;
                return _points;
            }
            else
            { 
                return _points + _bonusPoints;
            }
        }
        else
        {
            return 0;
        }
        
    }
}