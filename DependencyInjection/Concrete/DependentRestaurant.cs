using DependencyInjection_BankCorruption.Abstract;

namespace DependencyInjection_BankCorruption.Concrete;

public class DependentRestaurant : IRestaurant
{
    private readonly WonderFoodService _foodService;

    public DependentRestaurant(WonderFoodService foodService) => _foodService = foodService;

    public bool RequestOrder()
    {
        var order = new List<Ingredient>()
        {
            new Ingredient ("Tomatoes", 20 ),
            new Ingredient ("Steak", 15 ),
            new Ingredient ("Pepper", 25 ),
        };

        return _foodService.CompleteOrderProcess(order);
    }

    public bool Open()
    {
        var hasOrderArrivedToRestaurant = RequestOrder();

        if (hasOrderArrivedToRestaurant)
        {
            // prepare food with ingredients
            Console.WriteLine($"{GetType().Name} is open and serving customers!\n");
            return true;
        }

        Console.WriteLine($"Error: Could not get ingredients. {GetType().Name} is closed\n");
        return false;
    }
}

