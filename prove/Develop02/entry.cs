using System;
using System.Runtime.Intrinsics.Arm;

namespace journal;

class Entry
{
    public List<string> Create_entry(string _longDateValue, string _aPrompt)
    {
        /*
        this method adds all of the needs parts of each entry to a list so that it can store properly
        */
        List<string> _newEntry = new List<string>();
        _newEntry.Add(_longDateValue);
        _newEntry.Add(_aPrompt);
        _newEntry.Add(Write_entry());
        return _newEntry;
    }

    public string Write_entry()
    {
        /*
        this method records what the user inputs
        */
        string _input_entry = Console.ReadLine();
        return _input_entry;
    }

    public string Get_date()
    {
        /*
        this method gets the date from the computer and then saves in the csv file
        */
        var _dateTime = DateTime.Now;
        var _longDateValue = _dateTime.ToLongDateString();
        return _longDateValue;
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

    public void Display_text(List<string> _savedEntries)
    {
        /*
        this method displays all of the previous entries
        */
        Console.WriteLine("Here is your journal entries");
        int _amount = _savedEntries.Count;
        for (int i = 0; i < _amount; i++)
        {
            Console.WriteLine(_savedEntries[i]);
        }
    }

    public List<string> Read_file(string _file, List<string> _savedEntries)
    {
        /*
        this method reads in the file that was prompted for from the user 
        */
        StreamReader _sr = new StreamReader(_file);
        using (_sr)
        {
            while (!_sr.EndOfStream)
            {
                var _line = _sr.ReadLine();
                _savedEntries.Add(_line);
            }
        }
        return _savedEntries;
    }

    public void Save_text(string _file, List<string> _newEntry)
    {
        /*
        this method takes the entry and adds it to the csv file
        */
        File.AppendAllLines(_file, _newEntry);
    }
}