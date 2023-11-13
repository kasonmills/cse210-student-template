using System;
using Microsoft.VisualBasic;

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

    protected void ShowMessagePause(string, animationType, interval)
    {

    }

    private void ShowAnimations(animationType, interval)
    {
        /*
        this method needs to do either two or three options with the displaying the right animation it needs to either display a timer or
        it needs to display a animation of a spinner or other such things
        */
        switch(animationType)
        {
            case "countdown":
            {
                int count;
                for(interval; interval > 0; interval--)
                {
                    
                }
                break;
            }
            case "spinner":
            {
                break;
            }
            default:
            {
                Console.WriteLine("I couldn't find what you were looking for");
            }
        }
    }

    protected bool KeepGoing()
    {
        return false;
    }

    protected string GetRandomString(string[] _prompts)
    {
        return "";
    }
}