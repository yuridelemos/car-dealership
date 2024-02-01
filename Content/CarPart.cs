using car_dealership.Content.Enums;

namespace car_dealership.Content;

public class CarPart
{
    public CarPart(int id, string name, ECarManufacturer manufacturer,ESparePart part, int year, decimal price, DateTime purchaseDate)
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
        Part = part;
        Year = year;
        Price = price;
        PurchaseDate = purchaseDate;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public ECarManufacturer Manufacturer { get; set; }
    public ESparePart Part { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public DateTime PurchaseDate { get; set; }
}
