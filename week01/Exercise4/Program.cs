using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int num;

        while (true)
        {
            Console.Write("Enter a number (enter 0 to stop): ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                break;
            }

            numbers.Add(num);
        }

        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }

        double average = numbers.Count > 0 ? (double)total / numbers.Count : 0;

        int maximum = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int n in numbers)
        {
            if (n > maximum)
            {
                maximum = n;
            }
        }

        Console.WriteLine($"The total of the numbers is: {total}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}
