

namespace OpenClosedPrinciple;

public class EinsteinKineticEnergyCalculator : IKineticEnergyCalculator
{
    private const double LIGHT_SPEED = 299792458; 

    public double CalculateKineticEnergy(double mass, double velocity)
    { 
        double gamma = 1 / Math.Sqrt(1 - Math.Pow(velocity, 2) / Math.Pow(LIGHT_SPEED, 2));
        double kineticEnergy = (gamma - 1) * (mass * Math.Pow(LIGHT_SPEED, 2));
        return kineticEnergy;
    }

    public double CalculateVelocity(double kineticEnergy, double mass)
    { 
        double gamma = 1 + (kineticEnergy / (mass * Math.Pow(LIGHT_SPEED, 2)));
        double velocity = LIGHT_SPEED * Math.Sqrt(Math.Pow(gamma, 2) - 1) / gamma;
        return velocity;
    }

    public double CalculateMass(double kineticEnergy, double velocity)
    { 
        double gamma = 1 / Math.Sqrt(1 - Math.Pow(velocity, 2) / Math.Pow(LIGHT_SPEED, 2));
        double mass = kineticEnergy / ((gamma - 1) * Math.Pow(LIGHT_SPEED, 2));
        return mass;
    }
}
