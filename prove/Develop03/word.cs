using System;
using System.Collections.Generic;
namespace memorizer;
public class Word
{
    /*
    this class has everything to do the individual words in the scripture. It focuses on wether or not a word
    is hidden and what to display if the word is hidden
    */
    
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        // This is a constructor for the verse or verses involved
        _text = text;
    
    }

    public void Hide()
    {
        // this is a setter
        _isHidden = true;
    }

    public bool IsHidden()
    {
        // this is a getter
        return _isHidden;
    }

    public string DisplayWord()
    {
        // this method checks wether or not a word is hidden and what to display if that is true or not
        if(_isHidden)
        {
            // this is a comment for the pull request. I used to just return a single underscore for each word
            // I have now fixed it with this simple for loop that gets the word length and replaces the whole
            // word with underscores
            int numberOfLetters = _text.Length;
            string placeholder = "";
            for(int i = 0; i < numberOfLetters; i++)
            {
                placeholder += "_";
            }
            return placeholder;
        }
        else
        {
            return _text;
        }
    }
}