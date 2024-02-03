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
            var car = BuyerController.SelectCar(buyer);
            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            var maintenance = new Maintenance(scheduledDate, buyer, car);
            Maintenances.Add(maintenance);
        }
        else
            Console.WriteLine("Formato inválido. Certifique-se de usar o formato DD/MM/AAAA HH:mm.");
    }
    public void List()
    {
        // Criar método de mostrar apenas o cliente que o nome for compatível
        foreach (var item in Maintenances)
        {
            Console.WriteLine($"{item.Car.Name} de {item.Client.Name} está agendado para {item.ScheduledDate}");
        }
    }
}
