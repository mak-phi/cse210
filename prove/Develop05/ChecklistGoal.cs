public class ChecklistGoal : Goal
{
    private int _count;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _score = 0;
    }

    public override void RecordEvent()
    {
        _count++;
        if (_count == _target)
        {
            _score = GetPoints() + _bonus;
        }
        else
        {
            _score = GetPoints();
        }
    }
    public void SetCount(int count)
        {
            _count = count;
        }

        public int GetCount()
        {
            return _count;
        }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetTarget()
    {
        return _target;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        
        if (!(_count < _target))
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X":" ")}] {GetName()} ({GetDescription()}) -- Currently completed: {_count}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // Serialization
        return $"{GetType()}~!{GetName()}~!{GetDescription()}~!{GetPoints()}~!{GetScore()}~!{_count}~!{_target}~!{_bonus}~!{IsComplete()}";
    }
}