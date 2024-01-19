using System;

namespace journal;
class PromptGenerator
{
    /*
    this whole class may have not been needed in hindsight but the assignment required two classes so...
    */
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
}