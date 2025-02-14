using System;
using System.Collections.Generic;

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
        bool _active = true;

        //while loop to make the program actually useful
        while(_active)
        {
            Display_Menu();
            string _typed = Console.ReadLine();
            int _option = int.Parse(_typed);
            journal.SelectOption(_option);
            if (_option==5){
                break;
            }
        }
    }

    public static void Display_Menu()
    {
        /*
        this method only worries about displaying the menu for the journal
        */
        Console.WriteLine("\nJournal Menu");
        Console.WriteLine("Option 1: Create a new Journal Entry");
        Console.WriteLine("Option 2: Display your previous journal entries");
        Console.WriteLine("Option 3: Save your journal entry to a file");
        Console.WriteLine("Option 4: Load your journal from a specific file");
        Console.WriteLine("Option 5: Is used to quit the journal program");
        Console.WriteLine("To make a selection please press the corresponding number to the option you want.");
        Console.WriteLine("Then press enter.\n");
    }
}