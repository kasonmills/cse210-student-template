using System;
using System.Drawing;

namespace homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assign1 = new Assignment("John Smith", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        Math assign2 = new Math("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        Writing assign3 = new Writing("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}