using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _6._Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine()
                .Split();
            List<Vehicle> VehList = new List<Vehicle>();
            while (cmd[0]!="End")
            {
                Vehicle newVeh = new Vehicle(cmd[0], cmd[1], cmd[2], int.Parse(cmd[3]));
                VehList.Add(newVeh);
                cmd = Console.ReadLine()
                    .Split();
            }
            string model = Console.ReadLine();
            while (model!="Close the Catalogue")
            {
                int index = VehList.FindIndex(x => x.Model == model);
                Console.WriteLine(VehList[index].ToString());
                model = Console.ReadLine();
            }
            List<Vehicle> carList = VehList.Where(x => x.Type == "car")
                .ToList();
            List<Vehicle> truckList = VehList.Where(x => x.Type == "truck")
                .ToList();
            double carTotal = carList.Sum(x => x.HorsePower) ;
            double truckTotal = truckList.Sum(x => x.HorsePower);

            double carAverage = 0.00;
            double truckAverage = 0.00;
            if (carList.Count>0)
            {
                carAverage = carTotal / carList.Count;
                Console.WriteLine($"Cars have average horsepower of: {carAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (truckList.Count>0)
            {
                truckAverage = truckTotal / truckList.Count;
                Console.WriteLine($"Trucks have average horsepower of: {truckAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(string type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = hp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(Type=="car"? "Car":"Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
    }
}
