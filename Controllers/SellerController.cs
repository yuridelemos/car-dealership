using car_dealership.Content;

namespace car_dealership.Controllers;

internal class SellerController : Controller<Seller>
{
    internal List<Seller> Sellers = new List<Seller>();
    public void Register() => base.Register(Sellers);
    public void List() => base.List(Sellers);
    public Seller SelectItem() => base.SelectItem(Sellers);
}