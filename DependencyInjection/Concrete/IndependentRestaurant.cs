using DependencyInjection_BankCorruption.Abstract;

namespace DependencyInjection_BankCorruption.Concrete;

public class IndependentRestaurant : IRestaurant
{
    private readonly IFoodService _foodService;

    public IndependentRestaurant(IFoodService foodService) => _foodService = foodService;

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
            Console.WriteLine($"{GetType().Name} is open and serving customers!");
            return true;
        }

        Console.WriteLine($"Error: Could not get ingredients. {GetType().Name} is closed.");
        return false;
    }
}
