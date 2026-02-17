using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> _activities = new List<Activity>();

        _activities.Add(new Swim(new DateOnly(2026, 3, 13), 30, 30));
        _activities.Add(new Bike(new DateOnly(2026, 3, 14), 60, 12));
        _activities.Add(new Run(new DateOnly(2026, 3, 15), 30, 3));
        _activities.Add(new Swim(new DateOnly(2026, 3, 13), 45, 45));
        _activities.Add(new Bike(new DateOnly(2026, 3, 14), 90, 15));
        _activities.Add(new Run(new DateOnly(2026, 3, 15), 45, 5));


        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}