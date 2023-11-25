public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}"); 
        Console.Write("\nHow long, in seconds, would you like for your session? ");
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(7);
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("—");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("—");
        spinnerAnimation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            if (DateTime.Now < endTime)
            {
                string s = spinnerAnimation[i];
                Console.Write(s);
                Thread.Sleep(50);
                Console.Write("\b \b");

                i++;

                if (i >= spinnerAnimation.Count)
                {
                    i = 0;
                }
            }
            else
            {
                break;
            }  
        }

    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}