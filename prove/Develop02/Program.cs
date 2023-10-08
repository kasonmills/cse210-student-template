using System;

namespace journal;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Menu menu = new Menu();
        menu.Display_Menu();
        menu.Controller();
        
    }
}