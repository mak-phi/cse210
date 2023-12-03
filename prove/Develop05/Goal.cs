public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    protected int _score;
    
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _score = 0;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    
    public void SetScore(int score)
    {
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X":" ")}] {_name} ({_description})";
    }
    public abstract string GetStringRepresentation();
}