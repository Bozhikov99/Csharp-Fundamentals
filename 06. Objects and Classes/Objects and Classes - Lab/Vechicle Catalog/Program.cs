using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Vechicle_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine()
                .Split("/");
            List<Car> cars = new List<Car>();
            List<Truck> trucks= new List<Truck>();
            VechicleList vechs = new VechicleList();
            
            
            while (cmd[0]!="end")
            {
                if (cmd[0] == "Car")
                {
                    //Car/Audi/A3/110
                    Car currentCar = new Car
                    {
                        Brand = cmd[1],
                        Model = cmd[2],
                        HorsePower = cmd[3]
                    };
                    cars.Add(currentCar);
                }
                else if (cmd[0] == "Truck")
                {
                    Truck currentTruck = new Truck
                    {
                        Brand = cmd[1],
                        Model = cmd[2],
                        Weight = cmd[3]
                    };
                    trucks.Add(currentTruck);
                }
                cmd = Console.ReadLine()
                .Split("/");
            }

            List<Car> sortedCars=cars
                .OrderBy(cars=>cars.Brand)
                .ToList();
            List<Truck> sortedTrucks=trucks
                .OrderBy(trucks=>trucks.Brand)
                .ToList();

            trucks.OrderBy(trucks=>trucks.Brand);
            vechs.Cars = cars;
            vechs.Trucks = trucks;
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                for (int i = 0; i < sortedCars.Count; i++)
                {
                    //Audi: A3 - 110hp
                    Console.WriteLine($"{sortedCars[i].Brand}: {sortedCars[i].Model} - {sortedCars[i].HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                for (int i = 0; i < sortedTrucks.Count; i++)
                {
                    Console.WriteLine($"{sortedTrucks[i].Brand}: {sortedTrucks[i].Model} - {sortedTrucks[i].Weight}kg");
                }
            }

        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class VechicleList
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks{ get; set; }
    }

}
