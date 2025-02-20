public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    
    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }
    
    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, int currentCount) 
        : this(name, points, targetCount, bonusPoints)
    {
        _currentCount = currentCount;
    }
    
    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        
        if (IsComplete())
        {
            Console.WriteLine($"Bonus! You have earned {_bonusPoints} additional points!");
        }
    }
    
    public override bool IsComplete() => _currentCount >= _targetCount;
    
    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_name} ({_points} points) -- Currently completed: {_currentCount}/{_targetCount}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetBasicString()}:{_targetCount}:{_bonusPoints}:{_currentCount}";
    }
}
