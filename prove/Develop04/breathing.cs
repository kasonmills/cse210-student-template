using System;

namespace mindfulness;

class Breathing: Activity
{

    public Breathing(string name, string description) :base(name, description)
    {

    }
    public void StartActivity()
    {
        DisplayStartMessage(_name);
        _duration = SetTotalDuration(_name);
        DisplayDescription(_description);
        int segment = _duration / 8;
        for (int i = segment;segment > 0; segment--)
        {
            Console.WriteLine("Breathe in...");
            DisplayAnimations("countdown", 4);
            Console.WriteLine("Breathe out...");
            DisplayAnimations("countdown", 4);
        }
        ShowEndMessage(_name, segment * 8);
    }
}