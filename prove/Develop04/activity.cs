using System;

namespace mindfulness;

class Activity
{
    protected Activity(_name, _description);
    private string _description;
    private string _name;
    private int _duration;
    private DateOnly _startTime;
    public string ShowStartMessage(_duration)
    {
        return "";
    }

    public void ShowEndMessage()
    {

    }

    protected void ShowMessagePause(string, aninationType, interval)
    {

    }

    private void ShowAnimation(animationType, interval)
    {

    }

    protected bool KeepGoing()
    {
        return false;
    }

    protected string GetRandomString(string[])
    {
        return "";
    }
}