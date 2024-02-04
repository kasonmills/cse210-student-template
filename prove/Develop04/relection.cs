using System;

namespace mindfulness;

class Reflection: Activity
{
    private List<string> _promptsReflection;
    private List<string> _questions;
    Random rnd = new Random();

    public Reflection(string name, string description):base(name, description)
    {
        // define the two types of listing for the activity
        _promptsReflection = new List<string>();
        _questions = new List<string>();
    }
    public void StartActivity()
    {
        // this method will handle the reflection activity
        DisplayStartMessage(_name);
        // set the total duration
        _duration = SetTotalDuration(_name);
        DisplayDescription(_description);
        // start off with a random prompt
        string prompt = GetPrompt();
        DisplayPrompt(prompt);
        DisplayAnimations("buffer", 5);
        int start = _duration;
        // display to the user a random question every 5 seconds
        while (_duration != 0)
        {
            string question = GetQuestion();
            DisplayQuestion(question);
            DisplayAnimations("spinner", 5);
        }
        ShowEndMessage(_name, start);
    }
    
    private string GetPrompt()
    {
        // add all of the prompts to a list and then return a random entry in it
        _promptsReflection.Add("Think of a time when you stood up for someone else.");
        _promptsReflection.Add("Think of a time when you did something really difficult.");
        _promptsReflection.Add("Think of a time when you helped someone in need.");
        _promptsReflection.Add("Think of a time when you did something truly selfless.");
        int num = rnd.Next(_promptsReflection.Count);
        string single_prompt = _promptsReflection[num];
        return single_prompt;
    }
    
    private string GetQuestion()
    {
        // add all the questions into the list and then return a randomly selected one
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        int num2 = rnd.Next(_questions.Count);
        string single_question = _questions[num2];
        return single_question;
    }
    
    private void DisplayPrompt(string prompt)
    {
        // display to the user a random prompt
        Console.WriteLine(prompt);
    }

    private void DisplayQuestion(string question)
    {
        // display to the user a random question
        Console.WriteLine(question);
    }
}