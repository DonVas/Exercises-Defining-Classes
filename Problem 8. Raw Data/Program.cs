using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Problem_8._Raw_Data
{
    public class Program
    {
        public static void Main()
        {
            List<Car>cars=new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carParameter = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = carParameter[0];
                Engine engine=new Engine(int.Parse(carParameter[1]), int.Parse(carParameter[2]));
                Cargo cargo=new Cargo(int.Parse(carParameter[3]),carParameter[4]);
                List<Tire> tires=new List<Tire>();

                for (int j = 5; j < carParameter.Length; j+=2)
                {
                    double tirePressure = double.Parse(carParameter[j]);
                    int tireAge= int.Parse(carParameter[j+1]);

                    tires.Add(new Tire(tirePressure,tireAge));                    
                }

                cars.Add(new Car(model,engine,cargo,tires.ToList()));

            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1))
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else if (command == "flamable")
            {
                cars
                    .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
