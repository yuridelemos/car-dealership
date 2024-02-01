namespace car_dealership.Content;

public class Buyer : User
{
    public Buyer(int id, string name, long registerNumber, string email)
        : base(id, name, registerNumber, email)
    {
        Cars = new List<Car>();
        Pieces = new List<CarPart>();
    }
    public List<Car> Cars { get; set; }
    public List<CarPart> Pieces { get; set; }
}
