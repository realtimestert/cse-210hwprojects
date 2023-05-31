public abstract class Event
{
    private string Title;
    private string Description;
    private DateTime Date;
    private DateTime Time;
    private Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title} \nDescription: {Description}\nDate: {Date} \nTime:{Time}\nAddress: {address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        string eventType = GetType().Name;
        return $"Event Type: {eventType} \n{GetStandardDetails()}";
    }

    public string GetShortDetails()
    {
        string eventType = GetType().Name;
        return $"Event Type: {eventType} \nTitle: {Title} \nDate:{Date.ToShortDateString()}";
    }
}