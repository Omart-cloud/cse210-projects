using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage(); // Ask for duration and show starting message

        for (int i = 0; i < Duration; i += 6) // Each cycle takes ~6 sec (Inhale + Exhale)
        {
            Console.Write("\nBreathe In...");
            ShowCountdown(3);

            Console.Write("\nBreathe Out...");
            ShowCountdown(3); 
        }

        DisplayEndingMessage();
    }
}
