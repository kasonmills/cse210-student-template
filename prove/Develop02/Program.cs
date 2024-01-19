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
    
        PromptGenerator prompt = new PromptGenerator();
        Entry entry = new Entry();
        List<string> saved_entries = new List<string>();
        List<string> new_entry = new List<string>();
        bool active = true;

        //while loop to make the program actually useful
        while (active)
        {
            entry.Display_Menu();
            string typed = Console.ReadLine();
            int option = int.Parse(typed);
            switch(option)
            {
                case 1:
                    string longDateValue = entry.Get_date();
                    string promppp = prompt.Get_prompt();
                    Console.WriteLine($"{promppp}");
                    new_entry = entry.Create_entry(longDateValue, promppp);
                    break;
            
                case 2:
                    entry.Read_file(Get_file_name(), saved_entries);
                    entry.Display_text(saved_entries);
                    break;
                case 3:
                    entry.Save_text(Get_file_name(), new_entry);
                    break;
                case 4:
                    entry.Read_file(Get_file_name(), saved_entries);
                    entry.Display_text(saved_entries);
                    break;
                case 5:
                    active = false;
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
        string file = Console.ReadLine();
        return file;
    }
}