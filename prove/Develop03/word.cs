using System;
using System.Collections.Generic;
namespace memorizer;
public class Word
{
    /*
    this class has everything to do the individual words in the scripture. It focuses on wether or not a word
    is hidden and what to display if the word is hidden
    */
    
    string _text;
    bool _isHidden;

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
            return "_";
        }
        else
        {
            return _text;
        }
    }
}