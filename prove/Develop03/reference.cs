using System;

namespace memorizer;

public class DisplayManager
{
    /*
    this class will be concerned with displaying the scipture and the reference
    associated with it it will also clear the console so that you can display the
    new "scripture" that is modified. It will also pay attention to when the user
    presses the enter key so that it can then do it all over again.
    */
    Scripture scripture = new Scripture();
    Word word = new Word();

    public void displayScripture(List<string> verse, List<string> references)
    {
        /*
        this method will loop through the scripture and display the scripture
        I want to make this so that it will display the replaced words as well as
        the remaining words
        */
        string display = "";
        Console.WriteLine(references[0]);
        foreach(string entry in verse)
        {
            display += entry + " ";
        }
        Console.WriteLine(display);
    }

    public void keepGoing(List<string> verse, List<string> references)
    {
        /*
        this method will check to see if a they have either pressed the enter key
        or the q key and if they press the enter key then it will replace three words
        with dashes and then display the new scripture with the dashes set up in there.
        */
        Console.WriteLine("Press enter to continue or q to quit");
        string input;
        bool allBlanks = false;
        do
        {
            input = Console.ReadLine();
            
            {
                Console.Clear();
                verse = word.selectWords(verse, ref allBlanks);
                displayScripture(verse, references);
            }
        }while(input !="q" && !allBlanks);
    }
}