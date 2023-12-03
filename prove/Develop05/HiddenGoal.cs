using System.Formats.Asn1;

public class HiddenGoal : Goal
{
    private string _name = "Scripture study game";
    private string _description = "Complete the bible verse by filling in the blanks";
    private const int _points = 1500;
    private bool _isCompleted;
    private string _scripture;

    public HiddenGoal()
    {
        SetName(_name);
        SetDescription(_description);
        SetPoints(_points);
        _score = 0;
        _scripture = GenerateRandomScripture();
    }

    public void Play()
    {
        List<string> hiddenWords = new List<string>();
        Console.Clear();
        Console.WriteLine($"{GetName()} ({GetDescription()})\n");
        DisplayHiddenScripture(_scripture, hiddenWords); //The magic of pass-by-reference!!
        Console.WriteLine("\nType the missing words: ");
        foreach(string word in hiddenWords)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            ShowSpinner(2);
            if(hiddenWords.Contains(answer))
            {
                Console.Write(">> Correct\n");
                _isCompleted = true;
            }
            else
            {
                Console.Write(">> Fail\n");
                _isCompleted = false;
                ShowSpinner(2);
                break;
            }
        }

    }

    private void DisplayHiddenScripture(string originalScriptureText, List<string> hiddenWords)
    {
        string displayWord;
        int wordsLimit = 5;
        string[] parts = originalScriptureText.Split(" ");
        int numOfWordsToHide = -1;
        if (parts.Length > 2)
        {
            numOfWordsToHide = new Random().Next(1,wordsLimit);
        }

        for (int i = 0; i <= numOfWordsToHide; i++)
        {
            int hiddenWordIndex = new Random().Next(parts.Length);
            displayWord = "";
            for (int j = 0; j < parts[hiddenWordIndex].Length; j++)
            {
                displayWord += "_";
            }
            hiddenWords.Add(parts[hiddenWordIndex]);
            parts[hiddenWordIndex] = displayWord;
        }
        
        string displaySentence = string.Join(" ", parts);

        Console.WriteLine(displaySentence);
    }
    public override string GetStringRepresentation()
    {
        // Serialization
        return $"{GetType()}~!{GetName()}~!{GetDescription()}~!{GetPoints()}~!{GetScore()}~!{_isCompleted}";
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override void RecordEvent()
    {
        Play();
        if (_isCompleted)
        {
            _score = GetPoints();
        }
    }

    private string GenerateRandomScripture()
    {
        string scripture;
        string[] scriptures = new string[]{
        "And as Moses lifted up the serpent in the wilderness, even so must the Son of man be lifted up: That whosoever believeth in him should not perish, but have eternal life.",
        "But I say unto you, That every idle word that men shall speak, they shall give account thereof in the day of judgment.",
        };

        scripture = scriptures[new Random().Next(scriptures.Length)];

        return scripture;
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
}