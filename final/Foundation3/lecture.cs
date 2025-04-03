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

    public void DisplayEventInfoFull(string name, string date, string time, string address, string description, string speaker, int cap)
    {
        Console.WriteLine($"We are excited to announce an upcoming event! {name}.");
        Console.WriteLine($"This event will feature {speaker} as our special guest.");
        Console.WriteLine($"{description}");
        Console.WriteLine($"They will be speaking {date} at {time}.");
        Console.WriteLine($"They will be speaking at {address} which only holds up to {cap} people so make sure to get their early to get a seat.");
        Console.WriteLine($"We hope to see you there!");
    }
}