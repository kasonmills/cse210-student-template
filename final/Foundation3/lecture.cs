using System;
using System.Text.RegularExpressions;

namespace events;

class Lecture : Event
{
    protected string _speakerName;
    protected int _capacity;
    public Lecture(string name, string date, string time, string address, string description, string speaker, int cap) :base(name, date, time, address, description)
    {
        _speakerName = speaker;
        _capacity = cap;
    }

    public void DisplayEventInfoFull()
    {
        Console.WriteLine($"We are excited to announce an upcoming event! {_eventName}.");
        Console.WriteLine($"This event will feature {_speakerName} as our special guest.");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"They will be speaking {_eventDate} at {_eventTime}.");
        Console.WriteLine($"They will be speaking at {_eventAddress} which only holds up to {_capacity} people so make sure to get their early to get a seat.");
        Console.WriteLine($"We hope to see you there!");
    }
}