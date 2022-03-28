using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkExercice.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public int CalculateSpeed(int skill)
        {
            return skill * Speed;
        }

        public Car ()
        {

        }


        public Car (string model, int speed, string driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }
    }
}
