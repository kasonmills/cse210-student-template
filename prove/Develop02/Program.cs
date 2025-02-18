using System;

namespace journal;

class Program
{
    static void Main(string[] args)
    {
        /*
        This is the central hub of the program everything will be called upon from here
        */
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();

        string _typed = Console.ReadLine();
        int _option = int.Parse(_typed);
        journal.SelectOption(_option);
    }    
}