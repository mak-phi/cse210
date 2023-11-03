using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower()}, {char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower()} {char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower()}.");
    }
}