public class OutdoorEvent : Event
{
    private string WeatherWarning;

    public OutdoorEvent(string title, string description, DateTime date, DateTime time, Address address, string weatherwarning) : base(title, description, date, time, address)
    {
        this.WeatherWarning = weatherwarning;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {WeatherWarning}";
    }
}