using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car : WheeledVehicle
    {
        public EngineTypeEnum EngineTypeCar { get; set; }
        public double Consumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public int FuelInTank { get; set; }

        public Car(int id, string manufacturer, string model, int numwheels, string type, EngineTypeEnum carTypeEngine, double consumtion, int numberOfDoors, int maxSpeed) : base(id, manufacturer, model, numwheels, type)
        {
            EngineTypeCar = carTypeEngine;
            Consumption = consumtion;
            NumberOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
        }

        public Car()
        {

        }

        public virtual void Drive()
        {
            if(FuelInTank > 0 && FuelInTank < 50)
            {
                Console.WriteLine($"The car {Manufacturer} is driving. You have {FuelInTank} litres in the tank.");
            }
            else
            {
                Console.WriteLine($"Please visit petrol station, you do not have any {EngineTypeCar}.");

            }
        }

        public override void Repair()
        {
            Console.WriteLine($"Your car is in great condition! No need for visiting work shop.");
        }

        public void Info()
        {
            Console.WriteLine($"Information about the car: - {Manufacturer} {Model}, - Engine type {EngineTypeCar}, - consumption {Consumption} l/100km, - Maximum speed {MaxSpeed} km/h");
        }

    }
}
