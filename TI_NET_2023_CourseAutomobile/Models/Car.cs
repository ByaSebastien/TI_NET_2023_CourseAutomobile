using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_CourseAutomobile.Models
{
    public class Car
    {
        public Car(string brand, string model, int minSpeed, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }

        public override string ToString()
        {
            return
                $"Marque : {Brand}\n" +
                $"Modele : {Model}\n";
        }
    }
}
