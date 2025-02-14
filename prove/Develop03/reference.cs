using System;

namespace memorizer;

public class Reference
{
    /*
    this class will be concerned with displaying the scipture and the reference
    associated with it.
    */

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    private bool _multVerses;
    public Reference(string book, int chapter, int verse)
    {
        // this is a constructor for a singular verse
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // this is a constructor for multiple verses
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _multVerses = true;
    }

    public void DisplayReference()
    {
        // this method handles the display of the reference bases on wether or not it has multiple verses
        if (_multVerses)
        {
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else
        {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
    }

}