using System;
using System.Collections.Generic;

namespace journal;
public class Journal
{

    // program class that interacts with journal- journal the backend to let entry and prompt generator run.
    PromptGenerator _prompt = new PromptGenerator();
    Entry _entry = new Entry();
    List<string> _savedEntries = new List<string>();
    List<string> _newEntry = new List<string>();


    public void SelectOption(int _option)
    {
        switch (_option)
        {
            case 1:
                Console.WriteLine(_entry.Get_date());
                Console.WriteLine(_prompt.Get_prompt());
                _newEntry =_entry.Create_entry(_entry.Get_date(),_prompt.Get_prompt());
                break;

            case 2:
                _entry.Display_text(_newEntry);
                break;
            case 3:
                _entry.Save_text(Get_file_name(), _newEntry);
                break;
            case 4:
                _entry.Read_file(Get_file_name(), _savedEntries);
                _entry.Display_text(_savedEntries);
                break;
            default:
                break;
        }

    }
    public static string Get_file_name()
    {
        /*
        this method prompts the user for a file name so we know where to store the information
        */
        Console.WriteLine("What file are you working with?");
        string _file = Console.ReadLine();
        return _file;
    }

    public void Display_Menu()
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