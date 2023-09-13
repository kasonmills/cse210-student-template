using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter_grade = "A";

        if(grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }
        
        Console.WriteLine($"your letter grade is {letter_grade}");

        if(letter_grade == "A"|| letter_grade == "B" || letter_grade == "C")
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}