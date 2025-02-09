using System;
using System.IO;

public class BreathingActivity : Activity
{
    private static int timesCompleted = 0; // Tracks how many times the activity was performed

    public BreathingActivity() 
        : base("Breathing Activity", "This activity helps you relax by guiding your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        timesCompleted++;

        for (int i = 0; i < Duration; i += 6)
        {
            Console.Clear();
            Console.WriteLine("\n   🫁 Inhale...      ");
            ShowBreathingAnimation(3);

            Console.Clear();
            Console.WriteLine("\n   💨 Exhale...      ");
            ShowBreathingAnimation(3);
        }

        DisplayEndingMessage();
        SaveActivityLog("Breathing Activity");
    }

    private void ShowBreathingAnimation(int seconds)
    {
        string[] animationStages = { ".", "..", "...", "....", ".....", "......" };
        for (int i = 0; i < animationStages.Length; i++)
        {
            Console.Write($"\r{animationStages[i]}   ");
            System.Threading.Thread.Sleep(seconds * 100);
        }
        Console.Write("\r       ");
    }

    private void SaveActivityLog(string activityName)
    {
        string log = $"{DateTime.Now}: Completed {activityName}. Total times: {timesCompleted}";
        File.AppendAllText("activity_log.txt", log + Environment.NewLine);
    }
}
