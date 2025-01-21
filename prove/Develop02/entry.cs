using System;
using System.Runtime.Intrinsics.Arm;

namespace journal;

class Entry
{
    public List<string> Create_entry(string longDateValue, string a_prompt)
    {
        /*
        this method adds all of the needs parts of each entry to a list so that it can store properly
        */
        List<string> new_entry = new List<string>();
        new_entry.Add(longDateValue);
        new_entry.Add(a_prompt);
        new_entry.Add(Write_entry());
        return new_entry;
    }

    public string Write_entry()
    {
        /*
        this method records what the user inputs
        */
        string input_entry = Console.ReadLine();
        return input_entry;
    }

    public string Get_date()
    {
        /*
        this method gets the date from the computer and then saves in the csv file
        */
        var dateTime = DateTime.Now;
        var longDateValue = dateTime.ToLongDateString();
        return longDateValue;
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

    public void Display_text(List<string> saved_entries)
    {
        /*
        this method displays all of the previous entries
        */
        Console.WriteLine("Here is your journal entries");
        int amount = saved_entries.Count;
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine(saved_entries[i]);
        }
    }

    public List<string> Read_file(string file, List<string> saved_entries)
    {
        /*
        this method reads in the file that was prompted for from the user 
        */
        StreamReader sr = new StreamReader(file);
        using (sr)
        {
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                saved_entries.Add(line);
            }
        }
        return saved_entries;
    }

    public void Save_text(string file, List<string> new_entry)
    {
        /*
        this method takes the entry and adds it to the csv file
        */
        File.AppendAllLines(file, new_entry);
    }
}