using System;
using System.Runtime.InteropServices;

namespace journal;

class Program
{
    // I need a difference her to show that this is a an effective pull request...
    static void Main(string[] args)
    {
        /*
        This is the central hub of the program everything will be called upon from here
        */
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();

        journal.Display_Menu();
        bool running = true;

        while(running)
        {
            string _typed = Console.ReadLine();
            int _option = int.Parse(_typed);
            if(_option == 5)
            {
                running = false;
            }
            else
            {
                journal.SelectOption(_option);
            }
            journal.Display_Menu();
        }
    }    
}