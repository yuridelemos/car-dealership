namespace car_dealership.Controllers;

abstract class Controller<T>
{
    public void Register(List<T> items)
    {
        Console.WriteLine($"======= Registro {typeof(T).Name} =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CNPJ/CPF: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        items.Add((T)Activator.CreateInstance(typeof(T),
            (items.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine($"{typeof(T).Name} cadastrado(a) com sucesso.");
    }
    public void List(List<T> items) =>
        items
            .Select((item) => $"({item.GetType().GetProperty("Id").GetValue(item)}) " +
            $"- {item.GetType().GetProperty("Name").GetValue(item)}")
            .ToList()
            .ForEach(Console.WriteLine);

    public T SelectItem(List<T> items)
    {
        Thread.Sleep(200);
        //Console.Clear();
        Console.WriteLine($"======= Seleção de {typeof(T).Name} =======");
        List(items);
        Console.Write($"Selecione o(a) {typeof(T).Name} que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = items.Find(item => (int)item.GetType().GetProperty("Id").GetValue(item) == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"{typeof(T).Name} não encontrado(a).");
        return default(T);
    }
}
