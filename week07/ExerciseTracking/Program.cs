class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(
                new DateTime(2024, 2, 20), 
                30, 
                3.0
            ),
            new Cycling(
                new DateTime(2024, 2, 20), 
                45, 
                15.0
            ),
            new Swimming(
                new DateTime(2024, 2, 20), 
                40, 
                32
            )
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}