using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.ClassesOfCars.Classes;
using TaxiStation.ModelCar;
using TaxiStation.ModelCar.EuropeanCars.Germany.AUDI.ModelsAudi;
using TaxiStation.ModelCar.EuropeanCars.Germany.BMW.ModelsBMW;
using TaxiStation.ModelCar.EuropeanCars.Germany.Mercedes.ModelsMercedes;
using TaxiStation.Specifications;
using TaxiStation.TypesOfBody.Types;

namespace TaxiStation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Station station = new Station()
            {
                new BmwX5(30000)
                {
                    Color = "Black",
                    Fuel = Fuel.Diesel,
                    MaxSpeed = 250,
                    NumberOfSeats = 4,
                    Dimensions = new Dimensions(4700, 1850),
                    EngineCapacity = 250,
                    IsFourWheelDrive = true,
                    ReleaseYear = new DateTime(2000, 5, 23),
                    Type = new Crossover(),
                    RegistrationNumber = "Ru - 0001",
                    Class = new E(),
                    FuelConsumption = new FuelConsumption(15.6, 10.8),
                    DatePassingTechInspection = new DateTime(2005, 11, 11)
                },
                new AudiA6(18000)
                {
                    Color = "Red",
                    Fuel = Fuel.Diesel,
                    MaxSpeed = 280,
                    NumberOfSeats = 4,
                    Dimensions = new Dimensions(400, 1550),
                    EngineCapacity = 150,
                    IsFourWheelDrive = false,
                    ReleaseYear = new DateTime(2010, 5, 23),
                    Type = new Coupe(),
                    RegistrationNumber = "By - 7777",
                    Class = new C(),
                    FuelConsumption = new FuelConsumption(10.6, 7.8),
                    DatePassingTechInspection = new DateTime(2012, 8, 6)
                },
                new MerceresVito(11000)
                {
                    Color = "Silver",
                    Fuel = Fuel.Petrol,
                    MaxSpeed = 180,
                    NumberOfSeats = 14,
                    Dimensions = new Dimensions(5000, 1700),
                    EngineCapacity = 200,
                    IsFourWheelDrive = true,
                    ReleaseYear = new DateTime(1999, 7, 14),
                    Type = new Minivan(),
                    RegistrationNumber = "By - 1452",
                    Class = new C(),
                    FuelConsumption = new FuelConsumption(14.6, 8.8),
                    DatePassingTechInspection = new DateTime(2012, 8, 6)
                }
            };
            Console.WriteLine("Has the following cars:");
            station.PrintAll();

            Console.WriteLine("Results found for the maximum speed:");
            foreach (var c in station.FindOnSpeed(180,90))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("Results found for the maximum speed:");
            foreach (var c in station.FindOnSpeed(180, 90))
            {
                Console.WriteLine(c.ToString()+" max speed:"+c.MaxSpeed);
            }
            station.OrderByFuelCity();
            Console.WriteLine("After sorting:");
            station.PrintAll();

            Console.WriteLine("The cost of the Taxi-station:"+station.CalculateCost()+" $$");
        }
    }
}
