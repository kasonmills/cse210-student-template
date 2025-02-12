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
        Display_Menu();

        public static void Start()
    {
        bool _active = true;

        //while loop to make the program actually useful
        while (_active)
        {
            string _typed = Console.ReadLine();
            int _option = int.Parse(_typed);
            switch (_option)
            {
                case 1:
                    Journal journal = new Journal();
                    break;

                case 2:
                    _entry.Read_file(Get_file_name(), _savedEntries);
                    _entry.Display_text(_savedEntries);
                    break;
                case 3:
                    _entry.Save_text(Get_file_name(), _newEntry);
                    break;
                case 4:
                    _entry.Read_file(Get_file_name(), _savedEntries);
                    _entry.Display_text(_savedEntries);
                    break;
                case 5:
                    _active = false;
                    break;
                default:
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