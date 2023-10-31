using System;
using System.Collections.Generic;
namespace memorizer;
public class Word
{
    /*
    this class will select three random words in the the scripture and then
    replace the words in it.
    */
    
    Scripture scripture = new Scripture();
    Random rnd = new Random();
    public List <string> selectWords(List<string> verse)
    {
        /*
        this method will select three random words to be replaced. It also needs
        to be done without repeats. Not to mention it needs to possibly also replace
        the exact entry that it selected.
        */
        int lenOfScripture = verse.Count;
        List<int> used = new List<int>();
        int replace = rnd.Next(0, lenOfScripture);
        for (int i = 0; i < 3; i++)
        {
            int wordLength = verse[replace].Length;
            string rep = replaceWithDashes(verse, wordLength);
            verse[replace] = rep;
            while (!used.Contains(replace))
            {
                if(used.Contains(replace))
                {
                used.Add(replace);
                replace = rnd.Next(0, lenOfScripture);
                break;
                }
                else
                    break;
            }
            if(lenOfScripture == used.Count)
            {
                break;
            }
        }
        return verse;
    }

    string replaceWithDashes(List<string> verse, int wordLength)
    {
        /*
        this method will replace the chosen words with dashes according to the correct
        amount of so that they can still see the length of the word.
        */
        string newWord = "";
        for (int i = 0;i < wordLength;i++)
        {
            newWord += "_";
        }
        return newWord;
    } 
}