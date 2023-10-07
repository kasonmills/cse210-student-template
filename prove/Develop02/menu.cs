using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace journal;
class Menu
{
    public List<string> Read_file()
    {
        /*
        
        */
        string file = "journal.csv";
        StreamReader sr = new StreamReader(file);
        List<string> saved_entries = new List<string>();
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

    public void Save_text()
    {
        /*
        
        */
        try
        {
            File.AppendAllText(file, output.ToString());
        }
        catch(Exception)
        {
            Console.WriteLine("Data could not be written to the CSV file.");
            return;
        }
    }

    public string Reload_text()
    {
        /*
        
        */
        return "";
    }

    public void Display_text(List<string> saved_entries)
    {
        /*
        
        */
        int amount = saved_entries.Count;
        for(int i = 0; i <amount; i++)
        {
            Console.WriteLine(saved_entries[i]);
        }
    }
}