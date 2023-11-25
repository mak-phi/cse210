using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        Run();
    }

    public void Run()
    {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        PopulatePrompts();
        ShowSpinner(3);
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they " + 
        "related to this experience.");
        Console.Write("You may begin in: ");
        PopulateQuestions();
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        // Store count of original questions list since this this will changed 
        // by the GetRandomQuestion method.
        // Suggest alternative solution
        int numOfQuestions = _questions.Count;

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(_duration / numOfQuestions);
        }

        DisplayEndingMessage();
    }

    private void PopulatePrompts()
    {
        _prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }
    private void PopulateQuestions()
    {
        _questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomPrompt()
    {
        // This method alters the global prompts list. 
        // Preferred approach should not change the prompts list
        string randomPrompt ="";
        try
        {
            
            if (_prompts.Count > 0)
            {
                randomPrompt = _prompts[new Random().Next(_prompts.Count)];
                //Remove selected random prompt from the prompts list so 
                // that the same prompt is not generated next time this method is runs
                _prompts.Remove(randomPrompt);
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Trace.TraceError($"ArgumentOutOfRangeException error: {e}");
        }
        
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {        
        // This method alters the global questions list. 
        // Preferred approach should not change the questions list
        string randomQuestion ="";
        try
        {       
            if (_questions.Count > 0)
            {
                randomQuestion = _questions[new Random().Next(_questions.Count)];
                //Remove selected random question from the questions list so 
                // that the same question is not generated next time this method is runs
                _questions.Remove(randomQuestion);
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Trace.TraceError($"ArgumentOutOfRangeException error: {e}");
        }
        
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---\n");
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
    }
}