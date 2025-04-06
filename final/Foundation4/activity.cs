using System;

namespace workouts;

class Activity
{
    protected string _activityDate;
    protected string _activityLength;
    public Activity(string date, string length)
    {
        _activityDate = date;
        _activityLength = length;
    }

    public void GetSummary()
    {

    }
}