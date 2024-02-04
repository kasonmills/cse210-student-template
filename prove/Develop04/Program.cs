using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int choice;
        do
        {
            string breath = "Breathing";
            string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            string listing = "Listing";
            string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
            string reflecting = "Reflecting";
            string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\tQuit");
            Console.WriteLine("Select a choice from the menu: ");
            string anInput = Console.ReadLine();
            choice = int.Parse(anInput);

            switch (choice)
            {
                case 1:
                {
                    Activity activity = new Activity(breath, breathingDescription);
                    Breathing breathing = new Breathing(breath, breathingDescription);
                    breathing.StartActivity();
                    break;
                }
                case 2:
                {
                    Activity activity = new Activity(reflecting, reflectingDescription);
                    Reflection reflection = new Reflection(reflecting, reflectingDescription);
                    reflection.StartActivity();
                    break;
                }
                case 3:
                {
                    Activity activity = new Activity(listing, listingDescription);
                    Listing listing1 = new Listing(listing, listingDescription);
                    listing1.StartActivity();
                    break;
                }
            }

        }while(choice !=4);

    }
}