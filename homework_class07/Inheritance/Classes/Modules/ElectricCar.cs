using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ElectricCar : Car
    {
        public int BatteryCapcity { get; set; }
        public double BatteryPercentage { get; set; }
        public double MaxSpeedBattery { get; set; }

        public ElectricCar()
        {

        }

        public ElectricCar(int id, string manufacturer, string model, int numwheels, string type, EngineTypeEnum carTypeEngine, double consumtion, int numberOfDoors, int maxSpeed, int capacity, double percetages) 
            : base(id, manufacturer, model, numwheels, type, carTypeEngine, consumtion, numberOfDoors, maxSpeed)
        {
            BatteryCapcity = capacity;
            BatteryPercentage = percetages;
            MaxSpeedBattery = MaxSpeedOnBattery(maxSpeed);
            EngineTypeCar = EngineTypeEnum.electricity;
        }

        public double MaxSpeedOnBattery(int maxSpeed)
        {
            return maxSpeed * 1.15;
        }

        public void Recharge()
        {
            if(BatteryPercentage >= 0 && BatteryPercentage < 9)
            {
                Console.WriteLine("The car is charging now. You have {0} percetages battery.", BatteryPercentage);
                BatteryPercentage = 100;
                Console.WriteLine("The car is charged. You have {0} percetages battery.", BatteryPercentage);
            }
            else
            {
                Console.WriteLine("The car is charging now. You have {0} percetages battery.", BatteryPercentage - 10);
                BatteryPercentage = 100;
                Console.WriteLine("The car is charged. You have {0} percetages battery.", BatteryPercentage);
            }
        }

        public override void Drive()
        {
            if(BatteryPercentage > 0)
            {
                Console.WriteLine($"The electric car is driving! Maximum speed when using elecrtic vehicle is {MaxSpeedBattery} with currently {BatteryPercentage} battery percentages");
            }
            else
            {
                Console.WriteLine("You do not have battery. Please recharge the vehicle.");
            }
        }

        public void InfoElectric()
        {
            Console.WriteLine($"Information about the car: - {Manufacturer} {Model}, - Engine type {EngineTypeCar}, - consumption {Consumption} l/100km, " +
                $"- Maximum speed {MaxSpeed} km/h, - Maximum speed using battery {MaxSpeedBattery} km/h");
        }

    }
}
