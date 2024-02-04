using System;

namespace mindfulness;

class Reflection: Activity
{
    private List<string> _promptsReflection;
    private List<string> _questions;
    Random rnd = new Random();

    public Reflection(string name, string description):base(name, description)
    {
        _promptsReflection = new List<string>();
        _questions = new List<string>();
    }
    public void StartActivity()
    {
        DisplayStartMessage(_name);
        _duration = SetTotalDuration(_name);
        DisplayDescription(_description);
        string prompt = GetPrompt();
        DisplayPrompt(prompt);
        DisplayAnimations("buffer", 5);
        int start = _duration;
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
        Console.WriteLine(prompt);
    }

    private void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
    }
}