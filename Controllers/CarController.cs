using car_dealership.Content;

namespace car_dealership.Controllers;
internal class CarController : Controller<Car>
{
    internal List<Car> Cars = new List<Car>();
    private BuyerController BuyerController;
    private SellerController SellerController;

    public CarController(
        BuyerController buyerController,
        SellerController sellerController)
    {
        BuyerController = buyerController;
        SellerController = sellerController;
    }

    internal void Register() => base.List(Cars);
    internal void List() => base.List(Cars);
    internal Car SelectItem() => base.SelectItem(Cars);

    internal void Purchase()
    {
        var buyer = BuyerController.SelectItem();
        var seller = SellerController.SelectItem();
        Console.WriteLine("======= Escolha do Veículo =======");
        var car = SelectItem();
        buyer.Cars.Add(car);
        seller.Cars.Add(car);
        Cars.Remove(car);
        Thread.Sleep(200);
        Console.WriteLine("======= Compra realizada com sucesso =======");
    }
}
