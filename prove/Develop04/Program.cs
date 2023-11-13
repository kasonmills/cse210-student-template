using System;

namespace mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        var breathingActivity = new Breathing();
        Activity.ShowStartMessage();
        Activity.StartActivity();
        Activity.ShowEndMessage();
    }
}