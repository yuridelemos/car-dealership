using car_dealership.Content;

namespace car_dealership.Controllers;

internal class CarPartController : Controller<CarPart>
{
    internal List<CarPart> Pieces = new List<CarPart>();
    private BuyerController BuyerController;
    private SellerController SellerController;

    public CarPartController(
    BuyerController buyerController,
    SellerController sellerController)
    {
        BuyerController = buyerController;
        SellerController = sellerController;
    }

    internal void Register() => base.List(Pieces);
    internal void List() => base.List(Pieces);
    internal CarPart SelectItem() => base.SelectItem(Pieces);

    internal void Purchase()
    {
        var buyer = BuyerController.SelectItem();
        var seller = SellerController.SelectItem();
        Console.WriteLine("======= Escolha do Peça =======");
        //Colocar um jeito de escolher peças que caibam no carro que a pessoa possui
        var carPart = SelectItem();
        buyer.Pieces.Add(carPart);
        seller.Pieces.Add(carPart);
        Pieces.Remove(carPart);
        Thread.Sleep(200);
        Console.WriteLine("======= Compra realizada com sucesso =======");
    }
}
