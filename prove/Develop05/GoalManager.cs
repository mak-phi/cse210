public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _overallScore = 0;
    private const int _hiddenGoalActivationLimit = 1500;

    public void Start()
    {
        int option = -1;

        while (option != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: " + 
            "\n\t1. Create New Goal" + 
            "\n\t2. List Goals" + 
            "\n\t3. Save Goals" + 
            "\n\t4. Load Goals" + 
            "\n\t5. Record Event" + 
            "\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // Create New Goal
                CreateGoal();
                break;

                case 2: // List Goals
                ListGoalDetails(_goals);
                break;

                case 3: // Save Goals
                SaveGoals();
                break;

                case 4: // Load Goals
                LoadGoals();
                break;

                case 5: // Record Event
                RecordEvent();
                break;

                case 6: // Quit
                default:
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_overallScore} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i+1}. {_goals[i].GetName()}\n");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: " + 
        "\n\t1. Simple Goal" + 
        "\n\t2. Eternal Goal" + 
        "\n\t3. Checklist Goal" + 
        $"{(_overallScore > _hiddenGoalActivationLimit ? "\n\t4. Hidden Goal\n\t5. Cancel" : "\n\t4. Cancel")}");
        Console.Write("Which type of Goal would you like to create? ");
        int goalSelection = int.Parse(Console.ReadLine());
        
        string name = "";
        string description = "";
        int points = -1;
        
        if (goalSelection != 4)
        {
            Console.Write("What is the name of your Goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine());
        }
        
        switch(goalSelection)
        {
            case 1:    
            SimpleGoal simpleGoal =  new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            break;

            case 2:
            EternalGoal eternalGoal =  new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            break;

            case 3:
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal =  new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            break;

            case 4:
            if (_overallScore > _hiddenGoalActivationLimit)
            {
                HiddenGoal hiddenGoal =  new HiddenGoal();
                _goals.Add(hiddenGoal);
            }
            break;

            default:
            break;
        }
    }
    public void ListGoalDetails(List<Goal> goals)
    {
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {goals[i].GetDetailsString()}");
            }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goals did you accomplish? ");
        int accomplished = int.Parse(Console.ReadLine());
        if (accomplished > 0)
        {
            Goal accomplishedGoal = _goals[accomplished-1];
            if (!accomplishedGoal.IsComplete())
            {
                accomplishedGoal.RecordEvent();
                Console.WriteLine($"Congratulations! You have earned {accomplishedGoal.GetScore()} points!");
                _overallScore += accomplishedGoal.GetScore();
                Console.WriteLine($"You now have {_overallScore} points.");
            }
            else
            {
                Console.WriteLine($"You have already completed this goal. Please create a new goal");
            }

            if (_overallScore > _hiddenGoalActivationLimit)
            {
                Console.WriteLine("--- Hidden Goal unlocked!! ---");
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the for the goal file? ");
        string filename = Console.ReadLine();
        // Code to save goals
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the for the goal file? ");
        string filename = Console.ReadLine();
        // Code to load goals
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~!");

            string loadedType = parts[0];
            string loadedName = parts[1];
            string loadedDescription = parts[2];
            int loadedPoints = int.Parse(parts[3]);

            switch(loadedType)
            {
                case "SimpleGoal":    
                SimpleGoal simpleGoal = new SimpleGoal(loadedName, loadedDescription, loadedPoints);
                simpleGoal.SetScore(int.Parse(parts[4]));
                simpleGoal.SetIsComplete(bool.Parse(parts[5]));
                _goals.Add(simpleGoal);
                break;

                case "EternalGoal":    
                EternalGoal eternalGoal = new EternalGoal(loadedName, loadedDescription, loadedPoints);
                eternalGoal.SetScore(int.Parse(parts[4]));
                _goals.Add(eternalGoal);
                break;

                case "ChecklistGoal":
                int loadedTarget = int.Parse(parts[6]);
                int loadedBonus = int.Parse(parts[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(loadedName, loadedDescription, loadedPoints, loadedTarget, loadedBonus);
                checklistGoal.SetScore(int.Parse(parts[4]));
                checklistGoal.SetCount(int.Parse(parts[5]));
                _goals.Add(checklistGoal);
                break;
            }
            
        }
        foreach (Goal goal in _goals)
        {
            _overallScore += goal.GetScore();
        }
    }
}