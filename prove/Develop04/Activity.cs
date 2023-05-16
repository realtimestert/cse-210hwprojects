using System;

public class Activity
{
    private string activityName;
    private string activityDescription;
    protected int activityTime;

    public Activity(string _activityName, string _activityDescription, int _activityTime)
    {
        activityName = _activityName;
        activityDescription = _activityDescription;
        activityTime = _activityTime;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to {activityName}.");
        Console.Write("How long in seconds, would you like your session to last? ");
        string userInput = Console.ReadLine();
        activityTime = int.Parse(userInput);

        Console.WriteLine($"Thank you for choosing an option, your activity will begin soon.");
        LoadingDots();
    }

    // needs to have "DateTime" for time to work
    public DateTime ActivityLength()
    {
        int seconds = activityTime;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        return endTime;
    }

    public void EndingMessage()
    {
        Console.WriteLine("Good job!");
        LoadingDots();
        Console.WriteLine($"You have completed {activityTime} seconds of {activityName}.");
        LoadingDots();
    }

    public void Spinner(int seconds)
    {
        int i = 0;

        while (i <= seconds)
        {
            Console.Write(Emoji.Raised_Hand);
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
            Console.Write(Emoji.V);
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
            Console.Write(Emoji.Fist);
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
        }
    }

    public void CountDown()
    {
        for (int i = 3; i > 0; i--)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(3);
            Console.Write(i);
            Thread.Sleep(3000);
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.WriteLine("Almost there...");
            }
        }
    }

    public void LoadingDots()
    {
        for (int i = 3; i > 0; i--)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(3);
            Console.Write(i);
            Thread.Sleep(3000);
        }
    }
}