public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _score = 0;
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _score = GetPoints();
        _isCompleted = true;
        
    }
    public void SetIsComplete(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        // Serialization
        return $"{GetType()}~!{GetName()}~!{GetDescription()}~!{GetPoints()}~!{GetScore()}~!{_isCompleted}";
    }
}