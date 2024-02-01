using car_dealership.Content;
using car_dealership.Controllers;

namespace car_dealership;

internal class ManagementSystem
{
    private BuyerController BuyerController;
    private CarController CarController;
    private SellerController SellerController;

    public ManagementSystem(BuyerController buyerController, CarController carController, SellerController sellerController)
    {
        BuyerController = buyerController;
        CarController = carController;
        SellerController = sellerController;
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= Dealership System =======");
            Console.WriteLine("(1) - Menu Cliente");
            Console.WriteLine("(2) - Menu Funcionário");
            Console.WriteLine("(0) - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Client();
                    break;
                case "2":
                    Employee();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }

    private void Client()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= Client System =======");
            Console.WriteLine("(1) - Comprar Carro");
            Console.WriteLine("(2) - Comprar Peça");
            Console.WriteLine("(3) - Agendar Manutenção");
            Console.WriteLine("(4) - Checar Agendamento");

            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CarController.Purchase(option);
                    break;
                case "2":
                    CarController.Purchase(option);
                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
    private void Employee()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= Employee System =======");
            Console.WriteLine("(1) - Venda de Carro");
            Console.WriteLine("(2) - Venda de Peça");
            Console.WriteLine("(3) - Checar estoque");
            Console.WriteLine("(4) - Comissões a receber");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    public void DataLoading()
    {
        BuyerController.Buyers.Add(new Buyer(
            1,
            "Yuri",
            1234567890,
            "yuri@yuri.com"));
        BuyerController.Buyers.Add(new Buyer(
            2,
            "Jade",
            0987654321,
            "jade@jade.com"));
        CarController.Cars.Add(new Car(
            1,
            "Prisma",
            Content.Enums.ECarManufacturer.Chevrolet,
            2017,
            124343,
            35000m,
            DateTime.Now));
        CarController.Cars.Add(new Car(
            2,
            "Corolla",
            Content.Enums.ECarManufacturer.Toyota,
            2019,
            20000,
            85000m,
            DateTime.Now));
        SellerController.Sellers.Add(new Seller(
            1,
            "Steve",
            24681012,
            "steveseller@steveseller.com"));
        SellerController.Sellers.Add(new Seller(
            2,
            "Drake",
            135791113,
            "drakeseller@drakeseller.com"));
    }
}
