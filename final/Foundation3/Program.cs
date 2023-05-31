using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        List<Event> events = new List<Event>();

        DateTime schedule = new DateTime(1985, 10, 21);

        Address location = new Address("235 Randy Street", "Riverside", "California", "USA");

        events.Add(new LectureEvent("A Match Made in Space", "How one young boy is rudely awakened by a man named Darth Vader who says he must date this girl or he will melt his brain", schedule, schedule, location, "George McFly", 2500));
        events.Add(new OutdoorEvent("Struck by lightning", "Does lightning really strike twice?", schedule, schedule, location, "Watch for lightning!"));
        events.Add(new ReceptionEvent("Wedding of the Century", "Come to the wedding of the century, free snacks", schedule, schedule, location, "George, Marty, Emmet, and Jessica are all invited to the VIP lounge", "Everyone else is still invited to eat the snacks"));

        foreach (Event e in events)
        {
            Console.WriteLine($"Standard Details:\n{e.GetStandardDetails()}");
            Console.WriteLine($"Full Details:\n{e.GetFullDetails}");
            Console.WriteLine($"Short Description:\n{e.GetShortDetails}");
        }
    }
}