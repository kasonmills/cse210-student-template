using System;

namespace journal;
class Journal
{
    static void Main(string[] args)
    {
        /*
        This is the central hub of the program everything will be called upon from here
        */
        Console.WriteLine("Hello Develop02 World!");

        PromptGenerator _prompt = new PromptGenerator();
        Entry _entry = new Entry();
        List<string> _savedEntries = new List<string>();
        List<string> _newEntry = new List<string>();
        bool _active = true;

        //while loop to make the program actually useful
        while (_active)
        {
            _entry.Display_Menu();
            string _typed = Console.ReadLine();
            int _option = int.Parse(_typed);
            switch (_option)
            {
                case 1:
                    string _longDateValue = _entry.Get_date();
                    string _promptSingle = _prompt.Get_prompt();
                    Console.WriteLine($"{_promptSingle}");
                    _newEntry = _entry.Create_entry(_longDateValue, _promptSingle);
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