using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Speed_Racing
{
    public class Program
    {
        public static void Main()
        {
            HashSet<Car> cars = new HashSet<Car>();
            int nuberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nuberOfLines; i++)
            {
                //“<Model> <FuelAmount> <FuelConsumptionFor1km>”
                string[] carStrings = Console.ReadLine()
                    .Split()
                    .ToArray();
                string model = carStrings[0];
                int fuelAmount = int.Parse(carStrings[1]);
                double fuelFor1Km = double.Parse(carStrings[2]);
                cars.Add(new Car(model, fuelAmount, fuelFor1Km));
            }

            var command = Console.ReadLine()
                .Split()
                .ToArray();

            while (command[0]!="End")
            {
                if (command[0]== "Drive")
                {
                   var canBe= cars.First(x => x.Model == command[1])
                        .CanBeMoveDistance(int.Parse(command[2]));
                    if (!canBe)
                    {
                        Console.WriteLine("Insufficient fuel for the drive"); 
                    }
                }

                command = Console.ReadLine()
                    .Split()
                    .ToArray();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
