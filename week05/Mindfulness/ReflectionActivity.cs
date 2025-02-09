using System;
using System.Collections.Generic;

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
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "This activity helps you reflect on moments of strength and resilience in your life.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider this prompt: {prompt}\n");
        ShowCountdown(3);

        Console.WriteLine("Reflect on the following questions:");
        
        for (int i = 0; i < Duration; i += 5)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
