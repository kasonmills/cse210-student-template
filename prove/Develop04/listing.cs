using System;

namespace mindfulness;

class Listing: Activity
{
    private List<string> _promptsListing;
    private int _responseCount;
    Random rnd = new Random();

    public Listing(string name, string description) :base(name, description)
    {

    }

    public void StartActivity()
    {
        List<string> entries = new List<string>();
        DisplayStartMessage(_name);
        _duration = SetTotalDuration(_name);
        DisplayDescription(_description);
        string prompt = SelectRandomPrompt();
        DisplayPrompt(prompt);
        DisplayAnimations("buffer", 5);
        while (_duration !=0)
        {
            DisplayAnimations("spinner", _duration);
            Console.WriteLine(">");
            string input = Console.ReadLine();
            entries.Add(input);
        }
        _responseCount = CountEntries(entries);
        DisplayNumEntries(_responseCount);
        ShowEndMessage(_name, _duration);
    }
    
    private string SelectRandomPrompt()
    {
        _promptsListing.Add("Who are people that you appreciate?");
        _promptsListing.Add("What are personal strengths of yours?");
        _promptsListing.Add("Who are people that you have helped this week?");
        _promptsListing.Add("when have you felt the Holy Ghost this month?");
        _promptsListing.Add("Who are some of your personal heroes?");
        int geh = rnd.Next(_promptsListing.Count);
        string single_prompt = _promptsListing[geh];
        return single_prompt;
    }

    private int CountEntries(List<string> entries)
    {
        return entries.Count;
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    private void DisplayNumEntries(int _responseCount)
    {
        Console.WriteLine($"You Listed {_responseCount} entries");
    }
}