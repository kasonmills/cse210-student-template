using System;
using System.Runtime.Intrinsics.Arm;

namespace journal;

class Entry
{
    public List<string> Get_prompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        return prompts;
    }

    public List<string> Create_entry(string longDateValue, List<string> prompts)
    {
        Random random = new Random();
        int selection = random.Next(0,4);
        string a_prompt = prompts[selection];
        List<string> entry = new List<string>();
        entry.Add(longDateValue);
        entry.Add(a_prompt);
        string input_entry = Console.ReadLine();
        entry.Add(input_entry);
        return entry;
    }

    public string Get_date()
    {
        var dateTime = DateTime.Now;
        var longDateValue = dateTime.ToLongDateString();
        return longDateValue;
    }
}