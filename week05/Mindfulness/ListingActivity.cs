using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static int timesCompleted = 0;
    private List<string> usedPrompts = new List<string>();

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many things as you can.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        timesCompleted++;

        string prompt = GetUniquePrompt();
        Console.WriteLine($"\nConsider this prompt: {prompt}");
        ShowCountdown(3);

        List<string> responses = GetUserResponses();

        Console.WriteLine($"\nYou listed {responses.Count} items. Well done!");
        SaveActivityLog("Listing Activity", responses);
        DisplayEndingMessage();
    }

    private string GetUniquePrompt()
    {
        if (usedPrompts.Count == _prompts.Count)
            usedPrompts.Clear();

        string prompt;
        do
        {
            prompt = _prompts[new Random().Next(_prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }

    private List<string> GetUserResponses()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing your responses. Type 'done' when finished:");

        string response;
        while ((response = Console.ReadLine())?.ToLower() != "done")
        {
            responses.Add(response);
        }

        return responses;
    }

    private void SaveActivityLog(string activityName, List<string> responses)
    {
        string log = $"{DateTime.Now}: Completed {activityName}. Listed {responses.Count} items.";
        File.AppendAllText("activity_log.txt", log + Environment.NewLine);
    }
}
