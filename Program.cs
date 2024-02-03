using car_dealership;
using car_dealership.Controllers;

BuyerController buyerController = new BuyerController();
SellerController sellerController = new SellerController();
CarController carController = new CarController(buyerController, sellerController);
CarPartController carPartController = new CarPartController(buyerController, sellerController);
MaintenanceController maintenanceController = new MaintenanceController(buyerController);

var managementSystem = new ManagementSystem(
    buyerController,
    carController,
    carPartController,
    sellerController,
    maintenanceController);

managementSystem.DataLoading();
maintenanceController.Register();
maintenanceController.Register();
maintenanceController.List();
managementSystem.Run();
Console.ReadKey();