
using OpenClosedPrinciple;

var mass = 0.00001;
var velocity = 60000000;

var newton =new KineticEnergyCalculatorProgram(new NewtonKineticEnergyCalculator());
var einstein =new KineticEnergyCalculatorProgram(new EinsteinKineticEnergyCalculator());


var newtonKineticAnswer = newton.CalculateKineticEnergy(mass, velocity);

var einsteinKineticAnswer = einstein.CalculateKineticEnergy(mass,velocity);

Console.WriteLine($"Newton Answer: \t{newtonKineticAnswer}\nEinstein Answer: {einsteinKineticAnswer}");


Console.ReadLine();