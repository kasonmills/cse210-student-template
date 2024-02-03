using System;
using Microsoft.VisualBasic;

namespace mindfulness;

class Activity
{
    
    protected string _description;
    protected string _name;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage(string name)
    {
        // this method might need to pass the different names of the activities into it
        Console.WriteLine($"Welcome to the {name} activity");
        Console.WriteLine("\n");
    }

    protected void DisplayDescription(string description)
    {
        Console.WriteLine(description);
        Thread.Sleep(2000);
        Console.WriteLine("Prepare yourself.");
        Console.WriteLine("The activity will begin soon.");
        Console.WriteLine("\n");
    }

    protected int SetTotalDuration(string name)
    {
        Console.WriteLine($"How many seconds would you like the {name} activity to last?");
        string option = Console.ReadLine();
        _duration = int.Parse(option);
        return _duration;
    }

    public void ShowEndMessage(string _name, int _duration)
    {
        Console.WriteLine("Finished");
        Thread.Sleep(2000);
        Console.WriteLine($"Good Job! You completed the {_name} activity!");
        Thread.Sleep(2000);
        Console.WriteLine($"The activity lasted {_duration} seconds.");
        Console.WriteLine("\n");
    }

    protected void DisplayAnimations(string animationType, int interval)
    {
        /*
        this method needs to do either two or three options with the displaying the right animation it needs to either display a timer or
        it needs to display a animation of a spinner or other such things
        */
        switch(animationType)
        {
            case "countdown":
            {
                for(int i = interval; interval > 0; interval--)
                {
                    DisplayCountdown(interval);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    _duration--;
                }
                Console.WriteLine("\n");
                break;
            }
            case "spinner":
            {
                for (int i = interval; interval > 0; interval--)
                {
                    Console.Write("+");

                    Thread.Sleep(500);

                    Console.Write("\b \b"); // Erase the + character
                    Console.Write("-"); // Replace it with the - character
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    _duration--;
                }
                Console.WriteLine("\n");
                break;
            }
            case "buffer":
            {
                for(int i = interval; interval > 0; interval--)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("\n");
                break;
            }
            default:
            {
                Console.WriteLine("I couldn't find what you were looking for");
                break;
            }
        }
    }

    public void DisplayCountdown(int countdown)
    {
        Console.WriteLine(countdown);
    }
}