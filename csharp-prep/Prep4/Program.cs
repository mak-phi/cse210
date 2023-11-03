using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        int largestNumber = numbers[0];
        int smallestPositiveNum = numbers[0];
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
            if (num > 0 && num < smallestPositiveNum)
            {
                smallestPositiveNum = num;
            }
        }
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The average is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNum}");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine($"The sorted list is: {num}");
        }
    }
}
/*
  Enter a list of numbers, type 0 when finished.
  Enter number: 3
  Enter number: 5
  Enter number: 7
  Enter number: 3
  Enter number: 2
  Enter number: -1
  Enter number: -4
  Enter number: -8
  Enter number: 0
  The sum is: 7
  The average is: 0.875
  The largest number is: 7
  The smallest positive number is: 2
  The sorted list is:
  -8
  -4
  -1
  2
  3
  3
  5
  7
*/