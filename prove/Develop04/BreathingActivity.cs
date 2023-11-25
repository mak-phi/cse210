public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        Run();
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear(); 
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int duration = _duration;
        int pass = 5;

        if ((duration / 2) < (pass * 2))
        {
            pass = duration / 2;
        } 

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            if (duration > pass)
            {
                ShowCountDown(pass);
                duration -= pass;
                
                Console.Write("\nNow breathe out...");
                if (duration > pass)
                {
                    ShowCountDown(pass);
                    duration -= pass;
                }
                else
                {
                    ShowCountDown(duration);
                    break;
                }
            }
            else
            {
                ShowCountDown(duration);
                break;
            }
        }
        DisplayEndingMessage();
    }
}