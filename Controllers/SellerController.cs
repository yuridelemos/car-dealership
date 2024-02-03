using car_dealership.Content;

namespace car_dealership.Controllers;

internal class SellerController : Controller<Seller>
{
    internal List<Seller> Sellers = new List<Seller>();
    public void Register() => base.Register(Sellers);
    public void List() => base.List(Sellers);
    public Seller SelectItem() => base.SelectItem(Sellers);

    public void SalesCommission()
    {
        Console.WriteLine($"======= Seleção de vendedor =======");
        var seller = SelectItem();
        if (seller != null)
        {
            var totalComission = 0m;
            totalComission = seller.Cars.Sum(p => p.Price * 0.05m);
            totalComission += seller.Pieces.Sum(p => p.Price * 0.03m);
            Console.WriteLine($"A comissão total de {seller.Name} é R$ {totalComission.ToString("N2")}");
        }
        else
            Console.WriteLine($"Vendedor não encontrado(a).");
        Console.ReadKey();
    }
}