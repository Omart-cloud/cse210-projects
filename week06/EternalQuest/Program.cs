public class Program
{
    private static GoalManager _goalManager;
    
    public static void Main()
    {
        _goalManager = new GoalManager();
        bool running = true;
        
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    _goalManager.DisplayGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    DisplayScore();
                    break;
                case "7":
                    running = false;
                    break;
            }
        }
    }
    
    private static void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Display Score");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    
    private static void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        Goal goal = null;
        
        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, points);
                break;
            case "2":
                goal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, points, target, bonus);
                break;
        }
        
        if (goal != null)
        {
            _goalManager.AddGoal(goal);
        }
    }
    
    private static void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        _goalManager.SaveGoals(filename);
    }
    
    private static void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        _goalManager.LoadGoals(filename);
    }
    
    private static void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");
        _goalManager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _goalManager.RecordEvent(index);
    }
    
    private static void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_goalManager.GetScore()} points.");
    }
} 
