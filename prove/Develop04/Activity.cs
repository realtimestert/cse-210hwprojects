using System;

public class Activity
{
    private string activityName;
    private string activityDescription;
    protected int activityTime;

    public void StartingMessage()
    {

    }

    public void EndingMessage()
    {

    }

    public void CountDown()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void LoadingDots()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }
}