using System;

namespace events;

class Reception : Event
{
    protected bool _RSVP;
    public Reception(string name, string date, string time, string address, string description, bool reserve) :base(name, date, time, address, description)
    {
        _RSVP = reserve;
    }

    public void DisplayEventInfoFull()
    {
        
    }
}