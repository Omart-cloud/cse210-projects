using System;
using System.IO;
using System.Threading;

public abstract class Activity
{
    protected string _name { get; }
    protected string _description { get; }
    protected int _duration { get; private set; }
    
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void RunActivity();

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"{_description}\n");

        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r   \r");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }

    protected void SaveActivityLog(string activityName, int timesCompleted, string additionalInfo = "")
    {
        string log = $"{DateTime.Now}: Completed {activityName}. Total times: {timesCompleted}.{additionalInfo}";
        File.AppendAllText("activity_log.txt", log + Environment.NewLine);
    }
}