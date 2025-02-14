using System;
using System.IO;

class Program
{
    static void Main()
    {
        LoadPreviousLog();

        while (true)
        {
            DisplayMenu();
            
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "4") break;

            Activity activity = input switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            activity?.RunActivity();
        }
    }

    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    private static void LoadPreviousLog()
    {
        if (File.Exists("activity_log.txt"))
        {
            Console.WriteLine("Previous Activity Log:");
            Console.WriteLine(File.ReadAllText("activity_log.txt"));
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
/* Below are the creativity for this program:
For creativity sake I did the following:
For the Activity I:
1. Added persistent logging to track completed activities
2. Saves timestamps of when activities were completed
3. Tracks the number of times each activity has been completed
4. Shows activity history when starting the program
5. Added a pause to read the activity log before continuing for tracking and logging of the program.


For the Breathing Activity, I did the following:
1. Added emoji visuals (🫁 for inhale, 💨 for exhale)
2. Custom breathing animation with growing dots (".", "..", "...", etc.) for enhancement sake.


I improved Listing Activity by:
1. Tracks and saves the number of items listed in each session
2. Input validation to prevent empty responses
3. Provides detailed feedback about number of items listed


I included Advanced Prompt Management to:
1. Prevents prompt repetition until all prompts have been used
2. Maintains unique prompts across sessions using the _usedPrompts list
3. Automatically resets when all prompts have been used


In order to prevent error, I added:
1. Null checking in GetUserResponses
2. Using the null-conditional operator for safer string comparisons
3. Using readonly for lists to prevent accidental modifications


I also improved User Experience by using:
1. Clear screen management for better readability
2. Consistent animation patterns
3. Detailed progress feedback
4. More descriptive activity messages