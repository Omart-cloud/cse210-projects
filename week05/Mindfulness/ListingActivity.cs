using System;
using System.Collections.Generic;

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

    private int _count; // Stores the number of user inputs

    public ListingActivity() 
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many things as you can.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Start listing your responses. Type 'done' when finished:");

        string response;
        while ((response = Console.ReadLine())?.ToLower() != "done")
        {
            userResponses.Add(response);
        }

        _count = userResponses.Count;
        return userResponses;
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider this prompt: {prompt}\n");
        ShowCountdown(3);

        Console.WriteLine("Now, list as many things as you can:");
        List<string> responses = GetListFromUser();

        Console.WriteLine($"\nYou listed {_count} items. Well done!");

        DisplayEndingMessage();
    }
}
