using System;

public class Listing : Activity
{
    public Listing(string _activityName, string _activityDescription, int _activityTime) : base (_activityName, _activityDescription, _activityTime)
    {
    //PlaceHolder
    }
    //List<string> listingPrompt = new List<string>();
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
        int randomindex = rand.Next(userListing.Count);
        string listPrompt = userListing[randomindex];
        return listPrompt;
    }

    public void RunListing(int seconds)
    {
        Console.WriteLine("Write down as many responses as you can: ");
        Console.WriteLine(RandomListingPrompt());
        
        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"You may begin in {i} seconds\n");
            Thread.Sleep(1000);
            Console.Write("honk... mi mi mi mi mi...");
            Console.Clear();
        }
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        int counter = 0;

        while (currentTime < futureTime)
        {
            Console.Write("*");
            Console.ReadLine();
            currentTime = DateTime.Now;
            counter +=1;
        }
        Console.WriteLine($"You made a list of {userListing.Count} things.");
        EndingMessage();
    }
}