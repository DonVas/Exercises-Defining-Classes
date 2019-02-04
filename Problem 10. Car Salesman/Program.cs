using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Car_Salesman
{
    public class Program
    {
        public static void Main()
        {
            int numberOfEngine = int.Parse(Console.ReadLine());
            List<Engine> engines= new List<Engine>();

            for (int i = 0; i < numberOfEngine; i++)
            {
                string[] engineParam = Console.ReadLine()
                    .Split()
                    .ToArray();
                string model = engineParam[0];
                string power = engineParam[1];
                int x;
                int displacement;
                string efficiency;

                if (engineParam.Length == 4)
                {
                    displacement = int.Parse(engineParam[2]);
                    efficiency = engineParam[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                else if(engineParam.Length == 3 && int.TryParse(engineParam[2], out displacement))
                {
                    displacement = int.Parse(engineParam[2]);
                    engines.Add(new Engine(model,power, displacement));
                }
                else if (engineParam.Length == 3)
                {
                    efficiency = engineParam[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
                else if (engineParam.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                                  
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars =new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carParameters = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carModel = carParameters[0];
                Engine engine = engines.First(x => x.Model == carParameters[1]);

                if (carParameters.Length==2)
                {
                        cars.Add(new Car(carModel,engine));
                }
                else if(carParameters.Length==3)
                {
                    if (carParameters[2].All(Char.IsDigit))
                    {
                        int weight = int.Parse(carParameters[2]);
                        cars.Add(new Car(carModel, engine, weight));
                    }
                    else
                    {
                        string color = carParameters[2];
                        cars.Add(new Car(carModel, engine, color));
                    }                   
                }
                else if (carParameters.Length == 4)
                {
                    int weight = int.Parse(carParameters[2]);
                    string color = carParameters[3];
                    cars.Add(new Car(carModel, engine,weight, color));
                }
            }
            cars.ForEach(Console.WriteLine);
        }
    }
}
