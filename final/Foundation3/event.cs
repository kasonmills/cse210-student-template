using System;

namespace events;

class Event
{
    protected string _eventName;
    protected string _eventDate;
    protected string _eventTime;
    protected string _eventAddress;
    protected string _eventDescription;

    public Event(string name, string date, string time, string address, string description)
    {
        _eventName = name;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = address;
        _eventDescription = description;
    }

    public void DisplayEventInfoStandard(string _eventName, string _eventDate, string _eventTime, string _eventAddress, string _eventDescription)
    {
        Console.WriteLine($"Join us at the {_eventName}!");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"The event will be held on {_eventDate} at {_eventTime}.");
        Console.WriteLine($"The address is {_eventAddress}\n");
    }

    public void DisplayEventInfoBrief(string _eventName, string _eventDate)
    {
        Console.WriteLine($"The event coming up is a ");  // I am not too sure how to display the type of class yet...
        Console.WriteLine($"{_eventName}");
        Console.WriteLine($"It will be held {_eventDate}\nWe hope to see you there!");
    }
}