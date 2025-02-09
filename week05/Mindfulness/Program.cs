using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clears the console for a clean menu display
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunActivity();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunActivity();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }
    }
}
