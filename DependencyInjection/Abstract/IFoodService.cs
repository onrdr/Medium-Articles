using DependencyInjection_BankCorruption.Concrete;

namespace DependencyInjection_BankCorruption.Abstract;

public interface IFoodService
{
    bool IsBankrupt { get; set; }
    bool CompleteOrderProcess(List<Ingredient> order);
}
