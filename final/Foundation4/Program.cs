using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("June 15, 2024", 90, 21);
        CyclingActivity cyclingActivity = new CyclingActivity("August 8, 2024", 60, 25);
        SwimmingActivity swimmingActivity = new SwimmingActivity("May 27, 2025", 15, 12);

        List<Activity> activities = [runningActivity, cyclingActivity, swimmingActivity];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}