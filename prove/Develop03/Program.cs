using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("John", 3, 16, 17);
        // string text = "Pray without ceasing.";
        string text = "For God so loved the world, that he gave his only "+
        "begotten Son, that whosoever believeth in him should not perish, but "+
        "have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        string response;
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            
            if (response.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(new Random().Next(0,scripture.CountWords()));
            }
        }
        while (response.ToLower() != "quit");
    }
}