class ChecklistGoal : Goal
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
    
    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Gained {_points} points for {_name}!");
        if (_currentCount >= _targetCount)
        {
            Console.WriteLine($"Bonus! Gained {_bonusPoints} extra points for completing {_name}!");
        }
    }
    
    public override bool IsComplete() => _currentCount >= _targetCount;
    
    public override string GetDetailsString()
    {
        return ($"[ ] {_name} - {_points} points each ({_currentCount}/{_targetCount} completed)" 
                + (IsComplete() ? " [COMPLETED]" : ""));
    }
}
