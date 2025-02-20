public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }
    
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    
    public override bool IsComplete() => false;
    
    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_points} points)";
    }
    
    public override string GetStringRepresentation()
    {
        return GetBasicString();
    }
}
