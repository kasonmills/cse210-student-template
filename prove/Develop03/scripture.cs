using System;
using System.Collections.Generic;
namespace memorizer;

class Scripture
{
    /*
    this class will hold the lists that the scirptures and references
    for said scriptures
    */

    List<string> references = new List<string>();
    List<string> verse = new List<string>
        {
            "and",
            "it",
            "came",
            "to",
            "pass",
            "that",
            "I",
            "Nephi",
            "said",
            "unto",
            "my",
            "father",
            "I",
            "will",
            "go",
            "and",
            "do",
            "the",
            "things",
            "which",
            "the",
            "lord",
            "hath",
            "commanded",
            "for",
            "I",
            "know",
            "that",
            "the",
            "Lord",
            "giveth",
            "no",
            "commandments",
            "unto",
            "the",
            "children",
            "of",
            "men",
            "save",
            "he",
            "shall",
            "prepare",
            "a",
            "way",
            "for",
            "them",
            "that",
            "they",
            "may",
            "accomplish",
            "the",
            "thing",
            "which",
            "he",
            "commandeth",
            "them",
    };
public List<string> getScripture()
{
    List<string> verse = new List<string>();
    return verse;
}
public List<string> getReference()
    {
        /*
        this method will pull the reference from the list of references.
        */
        List<string> references = new List<string>();
        references.Add("1 Nephi 3:7");
        return references;
    }
}
