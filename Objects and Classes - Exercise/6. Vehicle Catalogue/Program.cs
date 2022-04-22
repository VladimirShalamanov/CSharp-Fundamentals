using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public override string ToString()
            {
                string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {this.Model}{Environment.NewLine}" +
                                    $"Color: {this.Color}{Environment.NewLine}" +
                                    $"Horsepower: {this.HorsePower}";

                return vehicleStr;
            }
        }

        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] arr = cmd.Split(' ').ToArray();
                string type = arr[0].ToLower();
                string model = arr[1];
                string color = arr[2].ToLower();
                int horsePower = int.Parse(arr[3]);
                var currentVehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(currentVehicle);
            }

            string modell;
            while ((modell = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == modell));
            }

            var onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
