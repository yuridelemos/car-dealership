using car_dealership.Content;

namespace car_dealership.Controllers;

internal class MaintenanceController
{
    internal List<Maintenance> Maintenances = new List<Maintenance>();
    private BuyerController BuyerController;

    public MaintenanceController(BuyerController buyerController)
        => BuyerController = buyerController;

    public void Register()
    {
        Console.Write("Digite a data e hora (DD/MM/AAAA HH:mm): ");
        string input = Console.ReadLine();

        string inputFormat = "dd/MM/yyyy HH:mm";

        if (DateTime.TryParseExact(input, inputFormat, null, System.Globalization.DateTimeStyles.None, out DateTime scheduledDate))
        {
            Thread.Sleep(2000);
            Console.WriteLine("Data e hora agendada: " + scheduledDate.ToString("dd/MM/yyyy HH:mm"));
            var buyer = BuyerController.SelectItem();
            if (buyer.Cars != null && buyer.Cars.Count > 0)
            {
                var car = BuyerController.SelectCar(buyer);
                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey();
                var maintenance = new Maintenance(scheduledDate, buyer, car);
                Maintenances.Add(maintenance);
                Console.WriteLine("Agendamento realizado com sucesso!");
            }
            else
                Console.WriteLine("Cliente inválido. Para realizar o agendamento de manutenção, o cliente deve ter no mínimo um carro.");
        }
        else
            Console.WriteLine("Formato inválido. Certifique-se de usar o formato DD/MM/AAAA HH:mm.");
    }
    public void List()
    {
        var buyer = BuyerController.SelectItem();
        if (buyer != null)
        {
            foreach (var item in Maintenances)
            {
                if (item.Client.Name == buyer.Name)
                    Console.WriteLine($"{item.Car.Name} de {item.Client.Name} está agendado para {item.ScheduledDate}");
            }
        }
        else
        {
            foreach (var items in Maintenances)
                Console.WriteLine($"{items.Car.Name} de {items.Client.Name} está agendado para {items.ScheduledDate}");
        }
        Console.ReadKey();
    }
}
