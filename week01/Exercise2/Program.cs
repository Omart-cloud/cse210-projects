using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
            if (percent % 10 >= 7) sign = "+";
            else if (percent % 10 < 3) sign = "-";
        }

        else if (percent  >= 80)
        {
            letter = "B";
            if (percent % 10 >= 7) sign = "+";
            else if (percent % 10 < 3) sign = "-";
        }

        else if (percent >= 70)
        {
            letter = "C";
            if (percent % 10 >= 7) sign = "+";
            else if (percent % 10 < 3) sign = "-";
        }

        else if (percent >= 60)
        {
            letter = "D";
            if (percent % 10 >= 7) sign = "+";
            else if (percent % 10 < 3) sign = "-";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter} {sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Well done, you passed!");
        }

        else 
        {
            Console.WriteLine("You need more efforts next time.");
        }



    }
}