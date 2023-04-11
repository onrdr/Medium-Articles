
namespace OpenClosedPrinciple;

public class KineticEnergyCalculatorProgram
{
    private readonly IKineticEnergyCalculator _kineticEnergyCalculator;

    public KineticEnergyCalculatorProgram(IKineticEnergyCalculator calculator)
    {
        _kineticEnergyCalculator = calculator;
    }

    public double CalculateKineticEnergy(double mass, double velocity)
    {
        return _kineticEnergyCalculator.CalculateKineticEnergy(mass, velocity);
    }

    public double CalculateVelocity(double kineticEnergy, double mass)
    {
        return _kineticEnergyCalculator.CalculateVelocity(kineticEnergy, mass);
    }

    public double CalculateMass(double kineticEnergy, double velocity)
    {
        return _kineticEnergyCalculator.CalculateMass(kineticEnergy, velocity);
    }
}
