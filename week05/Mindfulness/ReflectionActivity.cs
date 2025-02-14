using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    private static int _timesCompleted = 0;
    private readonly List<string> _usedPrompts = new List<string>();

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you reflect on moments of strength and resilience in your life.")
    {
    }

    public override void RunActivity()
    {
        DisplayStartingMessage();
        _timesCompleted++;

        string prompt = GetUniquePrompt();
        Console.WriteLine($"\nReflect on this: {prompt}");
        ShowCountdown(3);

        foreach (var question in _questions)
        {
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
        SaveActivityLog(_name, _timesCompleted);
    }

    private string GetUniquePrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
            _usedPrompts.Clear();

        string prompt;
        do
        {
            prompt = _prompts[new Random().Next(_prompts.Count)];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }
}