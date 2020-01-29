﻿using System;
using System.Collections.Generic;
using System.Linq;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVehicles = RNG.GetRandomInt(100, 1000);
            int milesTraveled = 0;
            double tollBoothRevenue = 0;
            List<IVehicle> vehicles = new List<IVehicle>();
            while (vehicles.Count < numberOfVehicles || vehicles.FindAll(match => match is Tank).Count < 1 || vehicles.FindAll(match => match is Car).Count < 1 || vehicles.FindAll(match => match is Truck).Count < 1)
            {
                vehicles.Add(GetRandomVehicle());
            }
            //Console.WriteLine(String.Format("{0,-30} {1,-20} {2, -5}", "Vehicle", "Distance Traveled", "Toll $"));
            string line = "-";
            while (line.Length < 58)
            {
                line += "-";
            }
            //Console.WriteLine(line);
            int counter = 0;
            foreach (IVehicle vehicle in vehicles)
            {
                if (counter % 30 == 0)
                {
                    Console.WriteLine(line + "\n" + String.Format("{0,-30} {1,-20} {2, 6}", "Vehicle Type", "Distance Traveled", "  Toll" + "\n" + line));
                }
                milesTraveled += vehicle.DistanceTraveled;
                tollBoothRevenue += vehicle.Toll;
                Console.WriteLine(vehicle.GetFancyString());
                counter++;
            }
            Console.WriteLine($"\nNumber of vehicles: {numberOfVehicles}\nTotal Miles Traveled: {milesTraveled}\nTotal Tollbooth Revenue: {tollBoothRevenue.ToString("C")}");
        }

        public static IVehicle GetRandomVehicle()
        {
            IVehicle vehicle;

            int vehicleTypeRoll = RNG.GetRandomInt(1, 10);

            if (vehicleTypeRoll == 10)
            {
                vehicle = new Tank();
            }
            else if (vehicleTypeRoll > 6)
            {
                vehicle = GetTruck();
            }
            else
            {
                vehicle = GetCar();
            }
            TravelVehicle(vehicle);
            return vehicle;
        }

        public static Truck GetTruck()
        {
            int axelCountRoll = RNG.GetRandomInt(1, 3);
            Truck truck = null;
            switch (axelCountRoll)
            {
                case 1:
                    truck = new Truck(4);
                    break;
                case 2:
                    truck = new Truck(6);
                    break;
                case 3:
                    truck = new Truck(8);
                    break;
                default:
                    break;
            }
            return truck;
        }

        public static Car GetCar()
        {
            int coinFlip = RNG.GetRandomInt(1, 100);
            return new Car(coinFlip % 10 == 0);
        }

        public static void TravelVehicle(IVehicle vehicle)
        {
            int distance = RNG.GetRandomInt(10, 240);
            vehicle.CalculateToll(distance);
        }

    }

    public static class RNG
    {
        private static Random random;

        private static void Init()
        {
            if (random == null) random = new Random();
        }

        public static int GetRandomInt(int min, int max)
        {
            Init();
            return random.Next(min, max + 1);
        }
    }
}
