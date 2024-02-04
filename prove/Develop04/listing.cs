using System;

namespace mindfulness;

class Listing: Activity
{
    private List<string> _promptsListing;
    private int _responseCount;
    Random rnd = new Random();

    public Listing(string name, string description) :base(name, description)
    {
        // create a new list for the prompts
        _promptsListing = new List<string>();
    }

    public void StartActivity()
    {
        // this method runs the listing activity
        List<string> entries = new List<string>();
        DisplayStartMessage(_name);
        // set the total duration for the activity
        _duration = SetTotalDuration(_name);
        DisplayDescription(_description);
        // get a random prompt to start
        string prompt = SelectRandomPrompt();
        DisplayPrompt(prompt);
        // give them time to think
        DisplayAnimations("buffer", 5);
        int start = _duration;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        // prompt the user for information until they run out of time
        while (currentTime < futureTime)
        {
            Console.WriteLine(">");
            string input = Console.ReadLine();
            entries.Add(input);
            currentTime = DateTime.Now;
        }
        // count the number of entries
        _responseCount = CountEntries(entries);
        // display the number of entries
        DisplayNumEntries(_responseCount);
        ShowEndMessage(_name, start);
    }
    
    private string SelectRandomPrompt()
    {
        // I thought it would be easier to add all the entries into the list and then select a random prompt in one method instead of two
        _promptsListing.Add("Who are people that you appreciate?");
        _promptsListing.Add("What are personal strengths of yours?");
        _promptsListing.Add("Who are people that you have helped this week?");
        _promptsListing.Add("when have you felt the Holy Ghost this month?");
        _promptsListing.Add("Who are some of your personal heroes?");
        int geh = rnd.Next(_promptsListing.Count);
        // select a single prompt
        string single_prompt = _promptsListing[geh];
        return single_prompt;
    }

    private int CountEntries(List<string> entries)
    {
        // I think this is called a getter method
        return entries.Count;
    }

    private void DisplayPrompt(string prompt)
    {
        // display the prompt
        Console.WriteLine(prompt);
    }

    private void DisplayNumEntries(int _responseCount)
    {
        // tell the user how many entries they listed
        Console.WriteLine($"You Listed {_responseCount} entries");
    }
}