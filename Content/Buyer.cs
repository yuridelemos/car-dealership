﻿namespace car_dealership.Content;

internal class Buyer : User
{
    public Buyer(int id, string name, long registerNumber, string email)
        : base(id, name, registerNumber, email)
    {
        Cars = new List<Car>();
    }
    public List<Car> Cars { get; set; }
}