using System;
using System.Collections.Generic;

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
        int am = verse.Count;

        Console.WriteLine(references[0]);
        for (int i = 0; i < am; i++)
        {
            Console.WriteLine(verse[i]);
        }
    }

    public void keepGoing(List<string> verse, List<string> references)
    {
        /*
        this method will check to see if a they have either pressed the enter key
        or the q key and if they press the enter key then it will replace three words
        with dashes and then display the new scripture with the dashes set up in there.
        */
        Console.WriteLine("Press enter to continue or q to quit");
        while(Console.ReadLine() !="q")
        {
            if(Console.ReadLine() == "\n")
            {
                Console.Clear();
                verse = word.selectWords(verse);
                displayScripture(verse, references);
            }
        }
    }
}