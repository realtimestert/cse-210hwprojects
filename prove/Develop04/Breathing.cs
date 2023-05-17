using System;

public class Breathing : Activity
{
    //public Breathing(int activityTime, string activityName) : base(activityTime, activityName)
    public Breathing(int activityTime, string activityName, string activityDescription) : base (activityName, activityDescription, activityTime)
    {
        //Null?
    }
    public void BreathIn()
    {
        Console.Write($"Breath in...");
        CountDown();
        Console.Clear();
    }

    public void BreathOut()
    {
        Console.Write($"\nBreathe out....");
        CountDown();
        Console.Clear();
    }

    public void RunBreathing(int seconds)
    {
        StartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = ActivityLength();
        while (startTime < endTime)
        {
            BreathIn();
            startTime = DateTime.Now;
            BreathOut();
            startTime = DateTime.Now;
        }
        EndingMessage();
        Console.Clear();
    }
}