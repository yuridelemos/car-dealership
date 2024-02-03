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
            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            var maintenance = new Maintenance(scheduledDate, buyer);
            Maintenances.Add(maintenance);
        }
        else
            Console.WriteLine("Formato inválido. Certifique-se de usar o formato DD/MM/AAAA HH:mm.");
        // Criar a escolha de carro se a pessoa tiver mais de um
    }
    public void List()
    {
        foreach (var item in Maintenances)
        {
            Console.WriteLine($"A manutenção de {item.Client.Name} está agendada para {item.ScheduledDate}");
        }
        Console.WriteLine("\nPressione qualquer tecla para continuar.");
        Console.ReadKey();
        // Criar um foreach que pegue Maintenences e escreva o nome de quem agendou e o carro
    }

    // Criar um método para checar a agenda
}
