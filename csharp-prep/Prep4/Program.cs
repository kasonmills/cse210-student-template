using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        int num = GetNumber();

        while (num != 0)
        {
            num = GetNumber();
            numbers.Add(num);
        }

        int cou = numbers.Count();
        int sum = 0;

        for (int a = 0; a < cou; a++)
        {
            sum += numbers[a];
        }
        Console.WriteLine($"The sum is: {sum}");

        double avg = sum / cou;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }

    static int GetNumber()
    {
        Console.WriteLine("Enter Number: ");
        string item = Console.ReadLine();
        int num = int.Parse(item);
        return num;
    }
}