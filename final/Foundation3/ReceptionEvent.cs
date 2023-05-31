public class ReceptionEvent : Event
{
    private string VIPInvites;
    private string MailOrder;

    public ReceptionEvent(string title, string description, DateTime date, DateTime time, Address address, string vipinvites, string mailorder) : base(title, description, date, time, address)
    {
        this.VIPInvites = vipinvites;
        this.MailOrder = mailorder;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}Very Important People: {VIPInvites}\nMailing List: {MailOrder}";
    }
}