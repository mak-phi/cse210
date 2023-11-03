using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        char letter;
        char sign = ' ';
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }
        
        if (gradePercentage % 10 >= 7 && (letter == 'B' || letter == 'C' || letter == 'D'))
        {
            sign = '+';
        }
        else if (gradePercentage % 10 < 3 && (letter == 'A' || letter == 'B' || letter == 'C' || letter == 'D'))
        {
            sign = '-';
        }
        
        Console.WriteLine($"{letter}{sign}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass the course, but remember, you only fail when you stop trying.");
        }
    }
}