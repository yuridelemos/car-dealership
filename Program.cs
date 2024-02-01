using car_dealership;
using car_dealership.Controllers;

BuyerController buyerController = new BuyerController();
SellerController sellerController = new SellerController();
CarController carController = new CarController(buyerController, sellerController);

var managementSystem = new ManagementSystem(
    buyerController,
    carController,
    sellerController);

managementSystem.DataLoading();
managementSystem.Run();
Console.ReadKey();