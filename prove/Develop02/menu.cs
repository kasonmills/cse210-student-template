using System;
using System.Runtime.CompilerServices;

namespace journal;
class Menu
{
    public string Read_file()
    {
        /*
        
        */
        filepath = ;
        string[] lines = System.IO.File.ReadAllLines(file);
        List<string> journal_history = new List<string>();
        foreach(string line in lines)
        {
            string[] places = line.Split(",");
            journal_history.Add(places);
        }
        return "";
    }

    public void Save_text()
    {
        /*
        
        */
    }

    public string Reload_text()
    {
        /*
        
        */
        return "";
    }

    public void Display_text()
    {
        /*
        
        */
        foreach(Entry in entry)
        {
            Console.WriteLine
        }
    }
}