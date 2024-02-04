using System;

namespace mindfulness;

class Breathing: Activity
{

    public Breathing(string name, string description) :base(name, description)
    {

    }
    public void StartActivity()
    {
        // this method runs the breathing activity
        DisplayStartMessage(_name);
        // set the amount of time you want the activity to last
        _duration = SetTotalDuration(_name);
        // give a description of the activity
        DisplayDescription(_description);
        // store the information of the length of the activity so that once I decrease its value to zero there is still a reference that has the right number
        int start = _duration;
        int segment = _duration / 8;
        for (int i = segment;segment > 0; segment--)
        {
            // One whole loop should last 8 seconds
            Console.WriteLine("Breathe in...");
            DisplayAnimations("countdown", 4);
            Console.WriteLine("Breathe out...");
            DisplayAnimations("countdown", 4);
        }
        ShowEndMessage(_name, start);
    }
}