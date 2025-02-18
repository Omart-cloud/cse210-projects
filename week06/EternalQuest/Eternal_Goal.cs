class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}
    
    public override void RecordEvent()
    {
        Console.WriteLine($"Gained {_points} points for {_name}!");
    }
    
    public override bool IsComplete() => false;
    
    public override string GetDetailsString()
    {
        return "[∞] " + _name + $" - {_points} points per completion";
    }
}