using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<ElectricCar> cars = FillInfo();
            await PrintInfo(cars);
        }

        static async Task ChargingCars(IEnumerable<ElectricCar> cars)
        {
            await Task.Run(() =>
           {
               foreach (ElectricCar car in cars)
               {
                   car.Charge();
               }
           });
        }

        static List<ElectricCar> FillInfo()
        {
            List<ElectricCar> cars = new List<ElectricCar>
            {
                new ElectricCar { BatteryLevel = 10, Model = "Mercedes", Year=2005},
                new ElectricCar { BatteryLevel = 15, Model = "BMW", Year=2001},
                new ElectricCar { BatteryLevel = 25, Model = "AUDI", Year=2007},
                new ElectricCar { BatteryLevel = 40, Model = "FORD", Year=2009},
                new ElectricCar { BatteryLevel = 75, Model = "LAMBORGHINI", Year=2015},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 15, Model = "BMW", Year=2001},
                new ElectricCar { BatteryLevel = 25, Model = "AUDI", Year=2007},
                new ElectricCar { BatteryLevel = 40, Model = "FORD", Year=2009},
                new ElectricCar { BatteryLevel = 75, Model = "LAMBORGHINI", Year=2015},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 10, Model = "Mercedes", Year=2005},
                new ElectricCar { BatteryLevel = 15, Model = "BMW", Year=2001},
                new ElectricCar { BatteryLevel = 25, Model = "AUDI", Year=2007},
                new ElectricCar { BatteryLevel = 40, Model = "FORD", Year=2009},
                new ElectricCar { BatteryLevel = 75, Model = "LAMBORGHINI", Year=2015},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 15, Model = "BMW", Year=2001},
                new ElectricCar { BatteryLevel = 25, Model = "AUDI", Year=2007},
                new ElectricCar { BatteryLevel = 40, Model = "FORD", Year=2009},
                new ElectricCar { BatteryLevel = 75, Model = "LAMBORGHINI", Year=2015},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
                new ElectricCar { BatteryLevel = 55, Model = "TOYOTA", Year=1995},
            };

            return cars;
        }

        static async Task PrintInfo(IEnumerable<ElectricCar> cars)
        {
            var watch = Stopwatch.StartNew();
            await ChargingCars(cars);
            watch.Stop();
            var elapsedSeconds = watch.ElapsedMilliseconds;
            int counter = 1;
            foreach (ElectricCar car in cars)
            {
                Console.WriteLine($"Car {counter} : Battery Level : {car.BatteryLevel}");
                counter++;
            }
            Console.WriteLine($"\nThis program finished in {elapsedSeconds} seconds");
            
        }
    }
}
