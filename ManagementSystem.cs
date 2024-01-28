namespace car_dealership;

internal class ManagementSystem
{
    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= Dealership System =======");
            Console.WriteLine("(1) - Menu Cliente");
            Console.WriteLine("(2) - Menu Funcionário");
            Console.WriteLine("(3) - Cadastro");
            Console.WriteLine("(0) - Sair");

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

    }
}
