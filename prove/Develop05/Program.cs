using System;
using goals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // I need to call goal manager here and call start in goal manager to start the program
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}