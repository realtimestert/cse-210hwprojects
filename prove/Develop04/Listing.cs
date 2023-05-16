using System;

public class Listing : Activity
{
    public Listing(string _activityName, string _activityDescription, int _activityTime) : base (_activityName, _activityDescription, _activityTime)
    {
    //PlaceHolder
    }
    List<string> listingPrompt = new List<string>();
    List<string> userListing = new List<string>
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week?" ,
        "When have you felt the Holy Ghost this month?" ,
        "Who are some of your personal heroes?"
    };

    public string RandomListingPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(listingPrompt.Count);
        string listPrompt = listingPrompt[index];
        return listPrompt;
    }

    public void RunListing(int seconds)
    {
        StartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = ActivityLength();
        RandomListingPrompt();
        CountDown();
        int counter = 0;
        while (startTime < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            userListing.Add(input);
            startTime = DateTime.Now;
            counter += 1;
        }
        Console.WriteLine($"You made a list of {userListing.Count} things.");
        EndingMessage();
    }
}