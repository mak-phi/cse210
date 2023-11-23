using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Vasily Zaytsev","Trigonometry","7.6","2-5");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Morgan Freeman","The Middle Passage","The Development of Non-verbal Language Among Enslaved Africans");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}