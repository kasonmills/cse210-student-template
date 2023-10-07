using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace journal;
class Menu
{

    public void Controller()
    {
        Entry entry = new Entry();
        string longDateValue = entry.Get_date();
        string a_prompt = entry.Get_prompt();
        List<string> new_entry = entry.Create_entry(longDateValue,a_prompt);
        string file = "journal.csv";
        List<string> saved_entries = new List<string>();
        Display_Menu();
        string typed = Console.ReadLine();
        int option = int.Parse(typed);
        while (option != 6)
        {
            if (option == 1)
            {
                a_prompt = "";
                entry.Create_entry(longDateValue, a_prompt);
            }
            else if (option == 2)
            {
                Display_text(saved_entries);
            }
            else if (option == 3)
            {
                Save_text(file, new_entry);
            }
            else if (option == 4)
            {
                Read_file(file, saved_entries);
                Display_text(saved_entries);
            }
            else if (option == 5)
            {
                entry.Create_entry(longDateValue, a_prompt);
            }
            Display_Menu();
        }
        Read_file(file, saved_entries);
        Save_text(file, new_entry);

    }
    public List<string> Read_file(string file, List<string> saved_entries)
    {
        /*
        
        */
        StreamReader sr = new StreamReader(file);
        using(sr)
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
        
        */
        File.AppendAllLines(file, new_entry);
    }

    public void Display_Menu()
    {
        /*
        I am not too sure if I need this...
        */
        Console.WriteLine("Journal Menu");
        Console.WriteLine("Option 1: Create a new Journal Entry");
        Console.WriteLine("Option 2: Display your previous journal entries");
        Console.WriteLine("Option 3: Save your journal entry to a file");
        Console.WriteLine("Option 4: Load your journal from a specific file");
        Console.WriteLine("Option 5: Be given a random prompt that will help you write your journal entry");
        Console.WriteLine("Option 6: Is used to quit the journal program");
        Console.WriteLine("To make a selection please press the corresponding number to the option you want.");
        Console.WriteLine("Then press enter.");
    }

    public void Display_text(List<string> saved_entries)
    {
        /*
        
        */
        Console.WriteLine("Here is your jouranl entries");
        int amount = saved_entries.Count;
        for(int i = 0; i < amount; i++)
        {
            Console.WriteLine(saved_entries[i]);
        }
    }
}