using System;
using System.Collections.Generic;
using System.IO;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    private static int timesCompleted = 0;
    private List<string> usedPrompts = new List<string>();

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you reflect on moments of strength and resilience in your life.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        timesCompleted++;

        string prompt = GetUniquePrompt();
        Console.WriteLine($"\nReflect on this: {prompt}");
        ShowCountdown(3);

        foreach (var question in _questions)
        {
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
        SaveActivityLog("Reflection Activity");
    }

    private string GetUniquePrompt()
    {
        if (usedPrompts.Count == _prompts.Count)
            usedPrompts.Clear(); // Reset when all have been used

        string prompt;
        do
        {
            prompt = _prompts[new Random().Next(_prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }

    private void SaveActivityLog(string activityName)
    {
        string log = $"{DateTime.Now}: Completed {activityName}. Total times: {timesCompleted}";
        File.AppendAllText("activity_log.txt", log + Environment.NewLine);
    }
}
