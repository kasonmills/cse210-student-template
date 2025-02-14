using System;

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

                break;

            case 2:
                _entry.Display_text(_savedEntries);
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
}