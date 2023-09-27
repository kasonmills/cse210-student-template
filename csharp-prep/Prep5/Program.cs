using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int number2 = SquareNumber(number);
        DisplayResult(number2, name);
    }

    static public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        string prompt = Console.ReadLine();
        int number = int.Parse(prompt);
        return number;
    }

    static int SquareNumber(int number)
    {
        int number2 = number * number;
        return number2;
    }

    static void DisplayResult(int number2, string name)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {number2}");
    }
}