using DependencyInjection_BankCorruption.Abstract;
using DependencyInjection_BankCorruption.Concrete;

var wonderService = new WonderFoodService();
var perfectService = new PerfectFoodService();
wonderService.IsBankrupt = true;

// *************************************************************************  

var dependentRestaurant = new DependentRestaurant(wonderService);

dependentRestaurant.Open();

// *************************************************************************

List<IFoodService> serviceList = new() { wonderService, perfectService };

foreach (var service in serviceList)
{
    if (!service.IsBankrupt)
    {
        var independentRestaurant = new IndependentRestaurant(service);
        if (independentRestaurant.Open())
            break;
    }
}












Console.ReadLine();
