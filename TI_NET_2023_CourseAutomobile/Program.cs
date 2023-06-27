
using TI_NET_2023_CourseAutomobile.Models;

Car c1 = new Car("Dodge", "RAM", 200, 300);
Car c2 = new Car("BM", "36", 200, 300);
Car c3 = new Car("GT", "Shelby", 200, 300);
Car c4 = new Car("Fiat", "Multiplat", 200, 300);
Car c5 = new Car("Peugeot", "206", 200, 300);
Car c6 = new Car("VW", "Golf", 200, 300);

RaceTrack raceTrack = new RaceTrack("Spa-Francorchamps", 7);

Competition competition = new Competition(raceTrack, 10);
competition.AddCar(c1);
competition.AddCar(c2);
competition.AddCar(c3);
competition.AddCar(c4);
competition.AddCar(c5);
competition.AddCar(c6);

competition.Init();
competition.Start();
competition.ShowWinner();
