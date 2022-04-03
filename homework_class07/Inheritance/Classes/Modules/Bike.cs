using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Bike : WheeledVehicle
    {
        public int NumberOfSPeedLeveles { get; set; }
        public bool IsElectric { get; set; }

        public Bike()
        {

        }

        public Bike(int id, string manufacturer, string model, int numwheels, string type, int speedLevels, bool isElectric) : base (id, manufacturer, model, numwheels, type)
        {
            NumberOfSPeedLeveles = speedLevels;
            IsElectric = isElectric;
        }

        public void Ride()
        {
            if(IsElectric)
            {
                Console.WriteLine("The bike has {0} speeds and is electric", NumberOfSPeedLeveles);
            }
            else
            {
                Console.WriteLine("The bike has {0} speeds and is not electric", NumberOfSPeedLeveles);
            }
        }

        public override void Repair()
        {
            Console.WriteLine("The bike should be repared as soon as possible!");
        }
    }
}
