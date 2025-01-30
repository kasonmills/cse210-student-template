using System;
using System.Collections.Generic;
namespace memorizer;

class Scripture
{
    /*
    this class will hold the scriptures and references for said scriptures
    */

    List<Word> _words = new List<Word>();
    Random rnd = new Random();
    private List<int> _selected;

    public Scripture(Reference _reference, string _text)
    {
        // this constructor is the main aspect of the program.
        List<string> words = _text.Split(' ').ToList();
        foreach (string _spot in words)
        {
            _words.Add(new Word(_spot));
        }
        _selected = new List<int>();
        
    }

    public void HideRandomWords()
    {
        /*
        this method is the bulkiest part of the program! Just figuring out the logic behind selecting a new word was
        quite a slog. it essentially has 4 seperate checks. First one checks whether or not the word has been hidden.
        the second checks to see if the word that was selected whether or not it has been hidden. Third check checks
        to see if which words are hidden and then if the word is hidden the final check is to see if all the words are
        hidden.
        */
        int _lenOfScripture = _words.Count();
        int _numberToHide = rnd.Next(1, _lenOfScripture + 1);

        for (int i = 0; i < 3; i++)
        {
            bool _IhidIt = false;
            // this for loop selects three words at random this is also check 1
            while(!_IhidIt)
            {
                // this while loop check to see if the selected word is hidden and if it is select a new one check 2
                if (_selected.Contains(_numberToHide))
                {
                    _numberToHide = rnd.Next(1, _lenOfScripture + 1);
                }
                else
                {
                    foreach(Word phrase in _words){
                        if (!phrase.IsHidden())
                        {
                            // this if statement hides the selected words check 3
                            _words[_numberToHide - 1].Hide();
                            _selected.Add(_numberToHide);
                            _IhidIt = true;
                            break;
                        }
                    }
                }
            }

            // this is statement will end the loop once everything is hidden check 4
            if (IsCompletelyHidden())
            {
                break;
            }
            
        }
    }

    public void DisplayScripture()
    {
        /*
        this method will loop through the scripture and display the scripture
        I want to make this so that it will display the replaced words as well as
        the remaining words
        */
        string _display = "";
        foreach(Word entry in _words)
        {
            _display += entry.DisplayWord() + " ";
        }
        Console.WriteLine(_display);
    }
    
    public bool IsCompletelyHidden()
    {
        // this method checks each and every word to see if it is hidden and as soon as it finds one that isn't
        // the program continues
        foreach(Word phrase in _words){
            if(!phrase.IsHidden())
            {
                return false;
            }
        }
        return true;
    }    
}
