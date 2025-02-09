public class Activity
{
    protected string Name { get; }
    protected string Description { get; }
    protected int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine($"{Description}\n");

        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"You completed {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)  // Loops for the given seconds
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r   \r");
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }
}
