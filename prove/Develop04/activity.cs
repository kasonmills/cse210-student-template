using System;
using Microsoft.VisualBasic;

namespace mindfulness;

class Activity
{
    
    private string _description;
    private string _name;
    private int _duration;
    private DateOnly _startTime;

    protected Activity(_name, _description)
    {

    }
    public void DisplayStartMessage(string _name)
    {
        // this method might need to pass the different names of the activities into it
        Console.WriteLine($"Welcome to the {_name} activity");
        Thread.Sleep(2000);
        Console.WriteLine("Prepare yourself.");
        Console.WriteLine("The activity will begin soon.");

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
        Console.WriteLine("How many seconds would you like the intervals to be?");
        string length = Console.ReadLine();
        int interval = int.Parse(length);
        return interval;
    }

    public void ShowEndMessage(string _name, int _duration)
    {
        Console.WriteLine("Finished");
        Thread.Sleep(1000);
        Console.WriteLine($"Good Job! You completed the {_name} activity!");
        Thread.Sleep(1000);
        Console.WriteLine($"The activity lasted {_duration} seconds.");
    }

    protected void SelectAnimation(int interval)
    {
        /*
        this method needs to evalulate which animation to show. it needs to work with all three of the child classes so they can
        evalulate for their needs. I need a switch case most likely need to know which activity is running and which animation matters
        in that moment. this method will likely be called multiple times to make it the most useful in the different situations.
        */
        
        DisplayAnimations("", interval);
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