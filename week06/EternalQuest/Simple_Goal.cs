public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }
    
    public SimpleGoal(string name, int points, bool isComplete) : base(name, points)
    {
        _isComplete = isComplete;
    }
    
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }
    
    public override bool IsComplete() => _isComplete;
    
    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name} ({_points} points)";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetBasicString()}:{_isComplete}";
    }
}
