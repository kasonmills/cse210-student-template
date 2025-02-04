using System;

namespace memorizer;

class Program
{
    static void Main(string[] args)
    {
        /*
        This is my director of the whole program. Everything is controlled from here.
        */
        Console.WriteLine("Hello Develop03 World!");
        // singular verse example
        // Reference _reference = new Reference("John", 3, 16);
        // string _text = "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        // multiple verse example
        Reference _reference = new Reference("Mosiah", 2, 40, 41);
        string _text = "40 O, all ye old men, and also ye young men, and you little children who can understand my words, for I have spoken plainly unto you that ye might understand, I pray that ye should awake to a remembrance of the awful situation of those that have fallen into transgression. 41 And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.";
        Scripture _scripture = new Scripture(_reference, _text);
        
        // display the full scripture once before the user starts removing words
        _reference.DisplayReference();
        _scripture.DisplayScripture();
        string input;

        do
        {
            // do the loop until the end
            Console.WriteLine("\nPress enter to continue or type quit to end");
            input = Console.ReadLine();
            if (input == "")
            {
                
                Console.Clear();
                _scripture.HideRandomWords();
                _reference.DisplayReference();
                _scripture.DisplayScripture();
            }
        }while(input !="quit" ^ _scripture.IsCompletelyHidden());
    }
}