
namespace OpenClosedPrinciple;

public interface IKineticEnergyCalculator
{
    double CalculateKineticEnergy(double mass, double velocity);
    double CalculateVelocity(double kineticEnergy, double mass);
    double CalculateMass(double kineticEnergy, double velocity);
}
