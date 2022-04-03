using Classes;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============================= CAR =================================");
            Car bmw = new Car(326158645, "BMW", "Series 3", 4, "Car", EngineTypeEnum.oil, 7, 4, 210);
            bmw.Info();
            bmw.FuelInTank = 20;
            bmw.Drive();
            bmw.Repair();

            Console.WriteLine("============================= Electric CAR =================================");
            ElectricCar tesla = new ElectricCar(232558, "Tesla", "s", 4, "Car", EngineTypeEnum.electricity, 5.3, 4, 230, 100, 25);
            tesla.InfoElectric();
            tesla.Drive();
            tesla.Repair();
            tesla.Recharge();

            Console.WriteLine("============================= Bike =================================");
            Bike bmx = new Bike(99662188, "BMX", "Road bike", 2, "Bike", 16, true);
            bmx.Ride();
            bmx.Repair();


            Console.ReadLine();
        }
    }
}
