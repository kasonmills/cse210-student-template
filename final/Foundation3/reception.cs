using System;

namespace events;

class Reception : Event
{
    protected string _RSVP;
    public Reception(string name, string date, string time, string address, string description, string reserve) :base(name, date, time, address, description)
    {
        _RSVP = reserve;
    }

    public void DisplayEventInfoFull()
    {
        Console.WriteLine($"We are excited to invite you to {_eventName}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"It will be held on {_eventDate} at {_eventAddress}");
        Console.WriteLine($"The event will start at {_eventTime}");
        Console.WriteLine($"Don't forget to {_RSVP}!");
    }
}