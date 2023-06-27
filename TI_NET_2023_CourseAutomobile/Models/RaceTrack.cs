using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_CourseAutomobile.Models
{
    public class RaceTrack
    {
        public RaceTrack(string name, double distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get; set; }
        public double Distance { get; set; }

        public double TempsAuTour(Car c)
        {
            Random r = new Random();
            int speed = r.Next(c.MinSpeed, c.MaxSpeed + 1);
            return (Distance / speed) * 60 * 60;
        }

        public override string ToString()
        {
            return
                $"Circuit : {Name}\n" +
                $"Distance : {Distance}";
        }
    }
}
