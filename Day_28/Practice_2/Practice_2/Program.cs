using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ElectricCar> cars = FillInfo();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ChargingCars(cars);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void ChargingCars(IEnumerable<ElectricCar> cars)
        {
            Parallel.ForEach(cars, car =>
            {
                car.Charge();
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
            };

            return cars;
        }
    }
}
