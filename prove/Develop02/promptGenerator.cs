using System;

namespace journal;

class PromptGenerator
{
    /*
    this whole class may have not been needed in hindsight but the assignment required two classes so...
    */
    public string Get_prompt()
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        /*
        this section lets one of the prompts be selected at random.
        */
        Random _random = new Random();
        int _selection = _random.Next(0, 4);
        string _aPrompt = _prompts[_selection];
        return _aPrompt;
    }
}