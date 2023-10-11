using System;
using System.Collections;
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
        string file = Get_file_name();
        List<string> saved_entries = new List<string>();
        int option = Get_option();
            Display_Menu();
            switch(option)
            {
                case 1:
                    a_prompt = "";
                    entry.Create_entry(longDateValue, a_prompt);
                    Save_text(file, saved_entries);
                    break;
            
                case 2:
                    Display_text(saved_entries);
                    break;
                case 3:
                    Save_text(file, new_entry);
                    break;
                case 4:
                    Get_file_name();
                    Read_file(file, saved_entries);
                    Display_text(saved_entries);
                    break;
            
                case 5:
                    entry.Create_entry(longDateValue, a_prompt);
                    break;
                default:
                    Display_Menu();
                    break;
            }
        Read_file(file, saved_entries);
        Save_text(file, new_entry);

    }

    int Get_option()
    {
        string typed = Console.ReadLine();
        int option = int.Parse(typed);
        return option;
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

    public string Get_file_name()
    {
        Console.WriteLine("What file are you working with?");
        string file = Console.ReadLine();
        return file;
    }
}