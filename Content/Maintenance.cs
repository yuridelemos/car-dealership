namespace car_dealership.Content;

public class Maintenance
{
    public Maintenance(DateTime scheduledDate, Buyer client)
    {
        ScheduledDate = scheduledDate;
        Client = client;
    }

    public DateTime ScheduledDate { get; set; }
    public Buyer Client { get; set; }
}
