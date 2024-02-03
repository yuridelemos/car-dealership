namespace car_dealership.Content;

public class Maintenance
{
    public Maintenance(DateTime scheduledDate, Buyer client, Car car)
    {
        ScheduledDate = scheduledDate;
        Client = client;
        Car = car;
    }

    public DateTime ScheduledDate { get; set; }
    public Buyer Client { get; set; }
    public Car Car { get; set; }
}
