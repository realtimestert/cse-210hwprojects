using System;

public class Breathing : Activity
{
    public void BreathIn()
    {
        Console.Write($"\nBreath in...");
        CountDown();
    }

    public void BreathOut()
    {
        Console.Write($"\nBreathe out....");
        CountDown();
    }

    public void RunBreathing()
    {
        BreathIn();
        BreathOut();
    }
}