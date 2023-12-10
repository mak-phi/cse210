using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        RunningActivity runningActivity = new RunningActivity();
        runningActivity.SetDate(2023, 12, 11);
        runningActivity.SetDuration(15);
        runningActivity.SetDistance(1.5);
        activities.Add(runningActivity);

        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2023, 12, 12), 25, 10);
        activities.Add(cyclingActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2023, 12, 13), 20, 30);
        activities.Add(swimmingActivity);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}