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
    public List <string> selectWords(List<string> verse, ref bool allBlanks)
    {
        /*
        this method will select three random words to be replaced. It also needs
        to be done without repeats. Not to mention it needs to possibly also replace
        the exact entry that it selected.
        */
        int lenOfScripture = verse.Count;
        int used = 0;
        bool finished = false;
        for (int i = 0; i < 3; i++)
        {
            
            int replace = rnd.Next(0, lenOfScripture);
            while(verse[replace].Contains('_')){
                replace = rnd.Next(0, lenOfScripture);
                if(CheckForDashes(verse)){
                    finished = true;
                    break;
                }
            }
            int wordLength = verse[replace].Length;
            if(finished){
                break;
            }
            string rep = replaceWithDashes(verse, wordLength);
            verse[replace] = rep;
            while (used < lenOfScripture)
            {
                used++;
                replace = rnd.Next(0, lenOfScripture);
                break;
            }
            if(lenOfScripture == used)
            {
                allBlanks = true;
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

    bool CheckForDashes(List<string> verse)
    {
        foreach(string phrase in verse){
            if(!phrase.Contains('_'))
                return false;
        }
        return true;
    }
}