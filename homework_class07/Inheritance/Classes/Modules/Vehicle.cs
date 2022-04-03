using System;

namespace Classes
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int id, string manufacturer, string model) 
        {
            ID = id;
            Manufacturer = manufacturer;
            Model = model;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The vehicle information: ID {ID}, from {Manufacturer}, with model {Model}");
        }

    }
}
