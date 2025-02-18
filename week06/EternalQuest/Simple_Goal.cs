class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }
    
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    
    public override bool IsComplete() => _isComplete;
    
    public override string GetDetailsString()
    {
        return (_isComplete ? "[X]" : "[ ]") + $" {_name} - {_points} points";
    }
}
