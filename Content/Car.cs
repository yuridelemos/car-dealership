using car_dealership.Content.Enums;

namespace car_dealership.Content;

public class Car
{
    public Car(int id, string name, ECarManufacturer manufacturer, int year, long mileageDriven, decimal price, DateTime purchaseDate)
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
        Year = year;
        MileageDriven = mileageDriven;
        Price = price;
        PurchaseDate = purchaseDate;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public ECarManufacturer Manufacturer { get; set; }
    public int Year { get; set; }
    public long MileageDriven { get; set; }
    public decimal Price { get; set; }
    public DateTime PurchaseDate { get; set; }
}
