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
        Console.WriteLine($"Please join us for {_eventName}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"It will be held on {_eventDate} at {_eventAddress}");
        Console.WriteLine($"will will begin the proceedings at {_eventTime}");
        Console.WriteLine($"the forecast shows {_weather} so be prepared!");
        Console.WriteLine("We hope to see you there!");
    }
}