using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        class CatalogVehicle
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }

            public CatalogVehicle()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        static void Main(string[] args)
        {
            CatalogVehicle vehicle = new CatalogVehicle();

            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] arr = cmd.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = arr[0];
                string brand = arr[1];
                string model = arr[2];
                int index = int.Parse(arr[3]);

                if (type == "Car")
                {
                    vehicle.Cars.Add(new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = index
                    });
                }
                else if (type == "Truck")
                {
                    vehicle.Trucks.Add(new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = index
                    });
                }
            }

            if (vehicle.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car carList in vehicle.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }
            if (vehicle.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truckList in vehicle.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }
}
