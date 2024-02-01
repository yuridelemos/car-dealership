using car_dealership.Content;

namespace car_dealership.Controllers;

internal class BuyerController : Controller<Buyer>
{
    internal List<Buyer> Buyers = new List<Buyer>();
    public void Register() => base.Register(Buyers);
    public void List() => base.List(Buyers);
    public Buyer SelectItem() => base.SelectItem(Buyers);

}