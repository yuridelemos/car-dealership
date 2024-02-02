using car_dealership;
using car_dealership.Controllers;

BuyerController buyerController = new BuyerController();
SellerController sellerController = new SellerController();
CarController carController = new CarController(buyerController, sellerController);
CarPartController carPartController = new CarPartController(buyerController, sellerController);

var managementSystem = new ManagementSystem(
    buyerController,
    carController,
    carPartController,
    sellerController);

managementSystem.DataLoading();
managementSystem.Run();
Console.ReadKey();