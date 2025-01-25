using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startDate;
    public string _endDate;

    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Start Date: {_startDate}");
        Console.WriteLine($"End Date: {_endDate}\n");
    }
}