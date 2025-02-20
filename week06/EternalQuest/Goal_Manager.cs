public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
            
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += ((ChecklistGoal)goal)._bonusPoints;
            }
        }
    }
    
    public void DisplayGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
                
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    Goal goal = CreateGoalFromString(parts);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
        }
    }
    
    private Goal CreateGoalFromString(string[] parts)
    {
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);
        
        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(name, points, bool.Parse(parts[3]));
            case "EternalGoal":
                return new EternalGoal(name, points);
            case "ChecklistGoal":
                int target = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int current = int.Parse(parts[5]);
                return new ChecklistGoal(name, points, target, bonus, current);
            default:
                return null;
        }
    }
    
    public int GetScore() => _score;
}