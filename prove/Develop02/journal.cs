using System;

namespace journal;
class Journal
{

    // program class that interacts with journal- journal the backend to let entry and prompt generator run.
    PromptGenerator _prompt = new PromptGenerator();
    Entry _entry = new Entry();
    List<string> _savedEntries = new List<string>();
    List<string> _newEntry = new List<string>();

    public static string Get_file_name()
    {
        /*
        this method prompts the user for a file name so we know where to store the information
        */
        Console.WriteLine("What file are you working with?");
        string _file = Console.ReadLine();
        return _file;
    }
}