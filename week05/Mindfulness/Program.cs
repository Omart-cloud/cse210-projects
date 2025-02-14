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