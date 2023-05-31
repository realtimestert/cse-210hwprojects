public class LectureEvent : Event
{
    private string Speaker;
    private int Capacity;

    public LectureEvent(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.Speaker = speaker;
        this.Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}