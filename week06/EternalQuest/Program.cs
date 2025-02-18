class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        
        manager.CreateGoal(new SimpleGoal("Impact 3 persons positively daily", 1000));
        manager.CreateGoal(new EternalGoal("Read Scriptures", 100));
        manager.CreateGoal(new ChecklistGoal("Attend Temple", 50, 10, 500));
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Show Goals\n2. Record Event\n3. Show Score\n4. Exit");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    manager.DisplayGoals();
                    break;
                case "2":
                    Console.WriteLine("Enter goal number to record event:");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manager.RecordEvent(index - 1);
                    }
                    break;
                case "3":
                    manager.ShowScore();
                    break;
                case "4":
                    running = false;
                    break;
            }
        }
    }
}
