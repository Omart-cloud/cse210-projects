public abstract class Goal
{
    protected string _name;
    protected int _points;
    
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    
    public int GetPoints() => _points;
    
    // Shared method for all derived classes
    protected string GetBasicString()
    {
        return $"{GetType().Name}:{_name}:{_points}";
    }
}