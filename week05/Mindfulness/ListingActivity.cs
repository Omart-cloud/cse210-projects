using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static int _timesCompleted = 0;
    private readonly List<string> _usedPrompts = new List<string>();

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many things as you can.")
    {
    }

    public override void RunActivity()
    {
        DisplayStartingMessage();
        _timesCompleted++;

        string prompt = GetUniquePrompt();
        Console.WriteLine($"\nConsider this prompt: {prompt}");
        ShowCountdown(3);

        List<string> responses = GetUserResponses();
        Console.WriteLine($"\nYou listed {responses.Count} items. Well done!");
        
        SaveActivityLog(_name, _timesCompleted, $" Listed {responses.Count} items.");
        DisplayEndingMessage();
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

    private List<string> GetUserResponses()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing your responses. Type 'done' when finished:");

        string response;
        while ((response = Console.ReadLine())?.ToLower() != "done")
        {
            if (!string.IsNullOrWhiteSpace(response))
                responses.Add(response);
        }

        return responses;
    }
}