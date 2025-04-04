using System;

namespace events;

class Outdoor : Event
{
    protected string _weather;
    public Outdoor(string name, string date, string time, string address, string description, string weather) :base(name, date, time, address, description)
    {
        _weather = weather;
    }

    public void DisplayEventInfoFull()
    {
        
    }
}