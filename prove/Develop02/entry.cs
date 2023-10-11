using System;
using System.Runtime.Intrinsics.Arm;

namespace journal;

class Entry
{
    public string Get_prompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        Random random = new Random();
        int selection = random.Next(0,4);
        string a_prompt = prompts[selection];
        return a_prompt;
    }

    public List<string> Create_entry(string longDateValue, string a_prompt)
    {
        List<string> new_entry = new List<string>();
        string input_entry = Write_entry();
        new_entry.Add(longDateValue);
        new_entry.Add(a_prompt);
        new_entry.Add(input_entry);
        return new_entry;
    }

    public string Write_entry()
    {
        string input_entry = Console.ReadLine();
        return input_entry;
    }

    public string Get_date()
    {
        var dateTime = DateTime.Now;
        var longDateValue = dateTime.ToLongDateString();
        return longDateValue;
    }
}