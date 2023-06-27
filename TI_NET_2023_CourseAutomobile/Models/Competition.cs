using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_CourseAutomobile.Models
{
    public class Competition
    {
        public List<Car> Cars { get; set; }
        public Dictionary<Car, double> Result { get; set; }
        public RaceTrack RaceTrack { get; set; }
        public int LapNumber { get; set; }

        public Competition(RaceTrack raceTrack, int lapNumber)
        {
            Cars = new List<Car>();
            Result = new Dictionary<Car, double>();
            RaceTrack = raceTrack;
            LapNumber = lapNumber;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void Init()
        {
            foreach (Car car in Cars)
            {
                Result.Add(car, 0);
            }
        }

        public void Start()
        {

            for (int i = 0; i < LapNumber; i++)
            {
                foreach (Car car in Cars)
                {
                    double temps = Math.Round(RaceTrack.TempsAuTour(car), 3);
                    int minute = (int)temps / 60;
                    int second = (int)temps % 60;
                    Console.WriteLine(car);
                    Console.WriteLine($"Effectue le tour {i + 1} avec un temp de {minute.ToString("D2")} : {second.ToString("D2")}");
                    Result[car] += temps;
                    Console.WriteLine("__________________________________________________");
                }
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("__________________________________________________");
            }
        }

        public void ShowWinner()
        {
            KeyValuePair<Car,double> kvpWinner = Result.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine("Le gagnant est : ");
            Console.WriteLine(kvpWinner.Key);
            int minute = (int)kvpWinner.Value / 60;
            int second = (int)kvpWinner.Value % 60;
            Console.WriteLine($"Avec un temp total de {minute.ToString("D2")} : {second.ToString("D2")}");
        }
    }
}
