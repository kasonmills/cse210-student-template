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
    public void DisplayStartMessage(string _name)
    {
        // this method might need to pass the different names of the activities into it
        Console.WriteLine($"Welcome to the {_name} activity");
    }

    protected void DisplayDescription(string _description)
    {
        // this method will get the description needed for the activity display it to the user
        Console.WriteLine(_description);
        Thread.Sleep(2000);
        Console.WriteLine("Prepare yourself.");
        Console.WriteLine("The activity will begin soon.");
        Console.WriteLine("\n");
    }

    protected int SetTotalDuration(string _name)
    {
        // this method will prompt the user for how long they want the duration of an activity to last
        // then pass that info into the activity so it can be used there
        Console.WriteLine($"How many seconds would you like the {_name} activity to last?");
        string option = Console.ReadLine();
        _duration = int.Parse(option);
        return _duration;
    }

    protected void ShowEndMessage(string _name, int _duration)
    {
        // this method tells the user that they have finished an activty and how long it lasted
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
                // this will just show the numbers of a countdown
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
                // this one makes a little spinner
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
                // this one just adds . until the time limit has been reached
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
                // this is here just in case I want to change this later for more complex coding instead of hard
                // coding in the method I want to use instead maybe prompting the user for it... IDK
                Console.WriteLine("I couldn't find what you were looking for");
                break;
            }
        }
    }

    public void DisplayCountdown(int countdown)
    {
        // this displays the number of what count down you are using
        Console.WriteLine(countdown);
    }
}