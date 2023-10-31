using System;

namespace memorizer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture();
        DisplayManager displayManager = new DisplayManager();
        /*
        this method will execute other commands needed in this class
        */
        List<string> verse = scripture.getScripture();
        List<string> references = scripture.getReference();
        displayManager.displayScripture(verse, references);
        displayManager.keepGoing(verse, references);
    }
}