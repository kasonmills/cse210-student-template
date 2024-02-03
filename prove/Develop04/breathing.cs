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
        while (_duration != 0)
        {
            DisplayAnimations("spinner", _duration);
            int segment = _duration / 4;
            Console.WriteLine("Breathe in...");
            DisplayAnimations("countdown", segment);
            Console.WriteLine("Breathe out...");
            DisplayAnimations("countdown", segment);
        }
        ShowEndMessage(_name, _duration);
    }
}