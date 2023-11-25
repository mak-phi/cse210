using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string description;
        int option = -1;
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:" +
            "\n\t1. Start breathing activity" +
            "\n\t2. Start reflecting activity" +
            "\n\t3. Start listing activity" +
            "\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                description = "This activity will help you relax by walking " + 
                "you through breathing in and out slowly. "+ 
                "Clear your mind and focus on your breathing.";
                BreathingActivity breathe = new BreathingActivity("Breathing Activity", description);
                break;

                case 2:
                description = "This activity will help you reflect on times in " + 
                "your life when you have shown strength and resilience. This " + 
                "will help you recognize the power you have and how you can use " + 
                "it in other aspects of your life.";
                ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", description);
                break;

                case 3:
                description = "This activity will help you reflect on the good " + 
                "things in your life by having you list as many things as you " + 
                "can in a certain area.";
                ListingActivity list = new ListingActivity("Listing Activity", description);
                break;

                case 4:
                default:
                break;
            }
        }
    }
}
/*
Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit
Select a choice from the menu: 
*/