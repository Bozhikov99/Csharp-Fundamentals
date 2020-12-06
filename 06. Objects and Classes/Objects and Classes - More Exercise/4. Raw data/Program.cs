using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Raw_data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //ChevroletExpress 215- engine speed 255- engine power 1200 - weight flamable
                string[] cmd = Console.ReadLine()
                    .Split();
                Car newCar = new Car(cmd[0], int.Parse(cmd[1]), int.Parse(cmd[2]), int.Parse(cmd[3]), cmd[4]);
                carList.Add(newCar);
            }
            string typeString = Console.ReadLine();
            List<Car> printList = carList.Where(x => x.CarCargo.Type == typeString)
                .ToList();
                
            if (typeString == "flamable")
            {
                printList = printList.Where(x => x.CarEngine.Power > 250)
                    .ToList();
                
            }
            else
            {
                printList = printList.Where(x => x.CarCargo.Weight < 1000)
                    .ToList();
            }
            foreach (Car x in printList)
            {
                Console.WriteLine($"{x.Model}");
            }
            
        }
    }
    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine{ get; set; }
        public Cargo CarCargo { get; set; }
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            Engine currentEngine = new Engine(enginePower, engineSpeed);
            Cargo cargoCurrent = new Cargo(cargoWeight, cargoType);
            CarEngine = currentEngine;
            CarCargo = cargoCurrent;
        }
        public override string ToString()
        {
            return $"{Model}";
        }
    }
    class Engine
    {
        public int Power { get; set; }
        public int Speed { get; set; }
        public Engine(int enginePower, int engineSpeed)
        {
            Power = enginePower;
            Speed = engineSpeed;
        }
    }
    class Cargo
    {
        public string Type { get; set; }
        public int Weight{ get; set; }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
