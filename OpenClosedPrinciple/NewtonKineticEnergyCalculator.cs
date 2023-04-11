
namespace OpenClosedPrinciple;

public class NewtonKineticEnergyCalculator : IKineticEnergyCalculator
{
    public double CalculateKineticEnergy(double mass, double velocity)
    {
        return 0.5 * mass * (velocity * velocity);
    }

    public double CalculateVelocity(double kineticEnergy, double mass)
    {
        return Math.Sqrt(2 * kineticEnergy / mass);
    }

    public double CalculateMass(double kineticEnergy, double velocity)
    {
        return 2 * kineticEnergy / (velocity * velocity);
    }
}
