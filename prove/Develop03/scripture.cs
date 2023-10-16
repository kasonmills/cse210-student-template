using System;

namespace memorizer;

class Scripture
{

    
    public string Get_Scripture()
    {
        Reference reference = new Reference();
        string part_1 = reference.Get_reference();
        string part_2 = reference.Create_scripture();
        string verse_and_reference = part_1 + part_2;
        return verse_and_reference;
    }

    public void Display_scripture()
    {
        Console.WriteLine(Get_Scripture());
    }

    public void Display_modified_scripture()
    {

    }
}