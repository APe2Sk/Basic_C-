using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class WheeledVehicle : Vehicle
    {
        public int NumebrOfWheels { get; set; }
        public string Type { get; set; }

        public WheeledVehicle()
        {

        }

        public WheeledVehicle(int id, string manufacturer, string model, int numwheels, string type) : base (id, manufacturer, model)
        {
            NumebrOfWheels = numwheels;
            Type = type;
        }

        public virtual void Repair()
        {
            Random rand = new Random();
            Console.WriteLine($"The {Type}, model: {Model} was serviced recently. The next workshop visit is in {rand.Next(10, 25)} months");
        }
    }
}
