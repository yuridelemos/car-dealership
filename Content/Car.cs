using car_dealership.Content.Enums;

namespace car_dealership.Content;

internal class Car
{
    public Car(string model, ECarManufacturer manufacturer, int year, long mileageDriven, decimal price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        MileageDriven = mileageDriven;
        Price = price;
    }

    public string Model { get; set; }
    public ECarManufacturer Manufacturer { get; set; }
    public int Year { get; set; }
    public long MileageDriven { get; set; }
    public decimal Price { get; set; }
}
