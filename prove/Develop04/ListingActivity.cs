using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
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
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
    
        GetListFromUser();
        Console.Write($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    private void PopulatePrompts()
    {
        _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void GetRandomPrompt()
    {
        // This method alters the global prompts list. 
        // Preferred approach should not change the prompts list
        string randomPrompt ="";
        try
        {
            
            if (_prompts.Count > 0)
            {
                randomPrompt = _prompts[new Random().Next(_prompts.Count)];
                //Remove selected random prompt  from the prompts list so 
                // that the same prompt is not generated next time this method is runs
                _prompts.Remove(randomPrompt);
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Trace.TraceError($"ArgumentOutOfRangeException error: {e}");
        }
        
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responseList = new List<string>();
        string response;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            responseList.Add(response);
            _count++;
        }

        return responseList;       
    }
}