using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private static int _timesCompleted = 0;

    public BreathingActivity() 
        : base("Breathing Activity", "This activity helps you relax by guiding your breathing.")
    {
    }

    public override void RunActivity()
    {
        DisplayStartingMessage();
        _timesCompleted++;

        for (int i = 0; i < _duration; i += 6)
        {
            Console.Clear();
            Console.WriteLine("\n   🫁 Inhale...      ");
            ShowBreathingAnimation(3);

            Console.Clear();
            Console.WriteLine("\n   💨 Exhale...      ");
            ShowBreathingAnimation(3);
        }

        DisplayEndingMessage();
        SaveActivityLog(_name, _timesCompleted);
    }

    private void ShowBreathingAnimation(int seconds)
    {
        string[] animationStages = { ".", "..", "...", "....", ".....", "......" };
        for (int i = 0; i < animationStages.Length; i++)
        {
            Console.Write($"\r{animationStages[i]}   ");
            Thread.Sleep(seconds * 100);
        }
        Console.Write("\r       ");
    }
}