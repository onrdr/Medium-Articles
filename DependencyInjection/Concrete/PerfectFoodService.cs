using DependencyInjection_BankCorruption.Abstract;

namespace DependencyInjection_BankCorruption.Concrete;

public class PerfectFoodService : IFoodService
{
    public bool IsBankrupt { get; set; } = false;

    public bool CompleteOrderProcess(List<Ingredient> order)
    {
        if (IsBankrupt)
            return false;

        // Preapere the order and send it
        foreach (var ingredient in order)
            ingredient.IsPrepared = true;

        Console.WriteLine("Perfect Food Service have prepared the order and sent it to the restaurant");

        return true;
    }
}
