using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random Rd = new Random();
        Console.WriteLine("Hello Prep3 World!");
        /*
        Console.WriteLine("What is the Magic number? ");
        string cin = Console.ReadLine();
        int magic = int.Parse(cin);
        */
        Console.WriteLine("Welcome to the guessing game!");
        bool again = true;
        
        do
        {
            int guess = GetGuess();
            int magic = Rd.Next(1,100);
            int attempts = 0;        

            while (guess != magic)
            {
                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                    guess = GetGuess();
                    attempts++;
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                    guess = GetGuess();
                    attempts++;
                }
                else
                {
                    break;
                }
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {attempts} guesses");
            }

            Console.WriteLine("Would you like to play again? (please input y or no)");
            string confirm = Console.ReadLine();

            if (confirm == "n")
            {
                break;
            }

        }while (again == true);
    }

    static int GetGuess()
    {
        Console.WriteLine("What is your guess? ");
        string c2 = Console.ReadLine();
        int guess = int.Parse(c2);
        return guess;
    }
}