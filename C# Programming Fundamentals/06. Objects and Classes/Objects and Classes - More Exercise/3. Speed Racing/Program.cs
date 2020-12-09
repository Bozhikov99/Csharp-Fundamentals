using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split();
                Car newCar = new Car(cmd[0], double.Parse(cmd[1]),double.Parse(cmd[2]));
                carList.Add(newCar);
            }
            string[] secCmd = Console.ReadLine()
                .Split();
            while (secCmd[0]!="End")
            {
                //Drive AudiA4 5
                Car currentCar = carList.Find(x => x.Model == secCmd[1]);
                currentCar.Drive(secCmd[1], double.Parse(secCmd[2]));
                secCmd= Console.ReadLine()
                    .Split();
            }
            foreach (Car x in carList)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKM { get; set; }
        public double TravelledKM { get; set; }
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelPerKM = fuelPerKm ;
            TravelledKM = 0;
        }
        public void Drive(string model, double km)
        {
            //Drive AudiA4 5
            
            if (FuelPerKM*km<=FuelAmount)
            {
                FuelAmount-= FuelPerKM *km;
                TravelledKM += km;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledKM}";
        }
    }
}
