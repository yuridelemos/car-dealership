using car_dealership.Content;

namespace car_dealership.Controllers;

internal class BuyerController : Controller<Buyer>
{
    internal List<Buyer> Buyers = new List<Buyer>();
    public void Register() => base.Register(Buyers);
    public void List() => base.List(Buyers);
    public Buyer SelectItem() => base.SelectItem(Buyers);

    public void List(Buyer items) =>
    items.Cars
        .Select((item, index) => $"({index + 1}) - {item.GetType().GetProperty("Name").GetValue(item)}")
        .ToList()
        .ForEach(Console.WriteLine);

    public Car SelectCar(Buyer buyer)
    {
        Console.WriteLine($"======= Seleção de carro para manutenção =======");
        List(buyer);
        Console.Write($"Selecione o carro que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = buyer.Cars.Find(item => (int)item.GetType().GetProperty("Id").GetValue(item) == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"Carro não encontrado(a).");
        return default;
    }


}