using System;

namespace memorizer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture();
        scripture.Display_scripture();
        scripture.Display_modified_scripture();
    }
}