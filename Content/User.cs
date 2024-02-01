namespace car_dealership.Content;

public class User
{
    public User(int id, string name, long registerNumber, string email)
    {
        Id = id;
        Name = name;
        RegisterNumber = registerNumber;
        Email = email;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public long RegisterNumber { get; set; }
    public string Email { get; set; }
}
