public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _score = 0;
    }

    public override void RecordEvent()
    {
        _score = GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Serialization
        return $"{GetType()}~!{GetName()}~!{GetDescription()}~!{GetPoints()}~!{GetScore()}";
    }
}