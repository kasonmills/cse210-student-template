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
    public void DisplayStartMessage(string _name)
    {
        // this method might need to pass the different names of the activities into it
        Console.WriteLine($"Welcome to the {_name} activity");
    }

    protected int SetTotalDuration(string _name)
    {
        Console.WriteLine($"How long would you like the {_name} activity to last?");
        string option = Console.ReadLine();
        _duration = int.Parse(option);
        return _duration;
    }

    protected int GetIntervals()
    {
        Console.WriteLine("How long would you like the intervals to be?");
        string length = Console.ReadLine();
        int interval = int.Parse(length);
        return interval;
    }

    public void ShowEndMessage(string _name)
    {
        Console.WriteLine($"Good Job! You completed the {_name} activity!");
    }

    protected void ShowMessagePause(string animationType, int interval)
    {
        DisplayAnimations(animationType, interval);
    }

    private void DisplayAnimations(string animationType, int interval)
    {
        /*
        this method needs to do either two or three options with the displaying the right animation it needs to either display a timer or
        it needs to display a animation of a spinner or other such things
        */
        switch(animationType)
        {
            case "countdown":
            {
                for(interval; interval > 0; interval--)
                {
                    Console.Write(interval);

                    Thread.Sleep(1000);

                    Console.Write("\b \b");
                }
                break;
            }
            case "spinner":
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.Write("+");

                    Thread.Sleep(500);

                    Console.Write("\b \b"); // Erase the + character
                    Console.Write("-"); // Replace it with the - character
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
                
                break;
            }
            case "buffer":
            {
                for(int i = 3; i >0; i--)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
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