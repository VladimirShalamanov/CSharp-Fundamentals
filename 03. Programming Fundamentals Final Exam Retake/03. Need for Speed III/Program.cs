using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carBrand = arr[0];
                int mileage = int.Parse(arr[1]);
                int fuel = int.Parse(arr[2]);

                cars.Add(carBrand, new int[] { mileage, fuel });
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] arr = cmd
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                string currCar = arr[1];

                if (type == "Drive")
                {
                    int distance = int.Parse(arr[2]);
                    int fuel = int.Parse(arr[3]);

                    if (cars[currCar][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                    else if (cars[currCar][1] > fuel)
                    {
                        cars[currCar][0] += distance;
                        cars[currCar][1] -= fuel;
                        Console.WriteLine($"{currCar} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (cars[currCar][0] >= 100000)
                    {
                        cars.Remove(currCar);
                        Console.WriteLine($"Time to sell the {currCar}!");
                    }
                }
                else if (type == "Refuel")
                {
                    int fuel = int.Parse(arr[2]);
                    int max = 75;

                    if (cars[currCar][1] + fuel <= max)
                    {
                        cars[currCar][1] += fuel;
                        Console.WriteLine($"{currCar} refueled with {fuel} liters");
                    }
                    else if (cars[currCar][1] + fuel > max)
                    {
                        int neededFuel = max - cars[currCar][1];
                        cars[currCar][1] += neededFuel;
                        Console.WriteLine($"{currCar} refueled with {neededFuel} liters");
                    }
                }
                else if (type == "Revert")
                {
                    int km = int.Parse(arr[2]);
                    int minimumKm = 10000;

                    if (cars[currCar][0] - km >= minimumKm)
                    {
                        cars[currCar][0] -= km;
                        Console.WriteLine($"{currCar} mileage decreased by {km} kilometers");
                    }
                    else if (cars[currCar][0] - km < minimumKm)
                    {
                        cars[currCar][0] = minimumKm;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
