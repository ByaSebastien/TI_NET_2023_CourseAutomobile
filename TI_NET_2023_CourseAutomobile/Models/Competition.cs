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
        public Dictionary<Car, List<double>> Result { get; set; }
        public RaceTrack RaceTrack { get; set; }
        public int LapNumber { get; set; }

        public Competition(RaceTrack raceTrack, int lapNumber)
        {
            Cars = new List<Car>();
            Result = new Dictionary<Car, List<double>>();
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
                Result.Add(car, new List<double>());
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
                    Result[car].Add(temps);
                    Console.WriteLine("__________________________________________________");
                }
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("__________________________________________________");
            }
        }

        public void ShowWinner()
        {
            //double bestTime = double.MaxValue;
            //Car winner;
            //foreach(KeyValuePair<Car, List<double>> kvp in Result)
            //{
            //    if(kvp.Value.Sum() < bestTime)
            //    {
            //        bestTime = kvp.Value.Sum();
            //        winner = kvp.Key;
            //    }
            //}

            KeyValuePair<Car,List<double>> kvpWinner = Result.OrderBy(kvp => kvp.Value.Sum()).First();
            Console.WriteLine("Le gagnant est : ");
            Console.WriteLine(kvpWinner.Key);
            double total = kvpWinner.Value.Sum();
            int minute = (int)total / 60;
            int second = (int)total % 60;
            Console.WriteLine($"Avec un temp total de {minute.ToString("D2")} : {second.ToString("D2")}");
            Console.WriteLine("____________________________________________________________________________");
            KeyValuePair<Car,List<double>> kvpBestLap = Result.OrderBy(kvp => kvp.Value.Min()).First();
            Console.WriteLine("Le participant qui a fait le meilleur tour est : ");
            Console.WriteLine(kvpBestLap.Key);
            double totalBestLap = kvpBestLap.Value.Min();
            int minuteBestLap = (int)totalBestLap / 60;
            int secondBestLap = (int)totalBestLap % 60;
            Console.WriteLine($"Avec un temp de {minuteBestLap.ToString("D2")} : {secondBestLap.ToString("D2")}");

            if(kvpWinner.Key == kvpBestLap.Key)
            {
                Console.WriteLine("INCROYABLE!!!");
            }
        }
    }
}
