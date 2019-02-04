using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7._Speed_Racing
{
    public  class Car
    {
        //model, fuel amount, fuel consumption for 1 kilometer 
        //“<Model> <FuelAmount> <FuelConsumptionFor1km>”
        //“Drive <CarModel>  <amountOfKm>”
        //“<Model> <fuelAmount>  <distanceTraveled>”

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1km { get; set; }

        public int DistanceTraveled { get; set; }

        public Car(string model,int fuelAmount,double fuelConsumptionFor1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1Km;
        }

        public bool CanBeMoveDistance(int distance)
        {
            double fuelForTravel = this.FuelConsumptionFor1km * distance;

            if (fuelForTravel <= this.FuelAmount)
            {
                this.FuelAmount -= fuelForTravel;
                this.DistanceTraveled += distance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder carBuilder = new StringBuilder();

            carBuilder.Append($"{this.Model} ");
            carBuilder.Append($"{this.FuelAmount:F2} ");
            carBuilder.Append($"{this.DistanceTraveled}");

            return carBuilder.ToString();
        }
    }
}
